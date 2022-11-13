using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Client.Common.Configurations;
using Application.Client.Common.Exceptions;
using Application.Client.Common.Interfaces;
using Application.Client.Common.Token;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ValidationException = FluentValidation.ValidationException;

namespace Application.Client.Features.Identities.Commands.RefreshTokens
{
    public class RefreshTokensCommandHandler : IRequestHandler<RefreshTokensCommand, RefreshTokensViewModel>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly ITokenService _tokenService;
        private readonly AuthenticationConfiguration _authenticationConfiguration;
        public RefreshTokensCommandHandler(
            IApplicationDbContext dbContext, 
            ITokenService tokenService,
            AuthenticationConfiguration authenticationConfiguration)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
            _authenticationConfiguration = authenticationConfiguration;
        }

        public async Task<RefreshTokensViewModel> Handle(
            RefreshTokensCommand request, CancellationToken cancellationToken)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            var username = principal.Identity.Name;

            var user = await _dbContext.Users
                .SingleOrDefaultAsync(u => u.Username == username, cancellationToken);

            if (user == null)
                throw new ValidationException("User Not Found!");

            if (!user.IsActive)
                throw new ValidationException("User Is Not Active!");
            
            if (user.RefreshTokenExpireDateTime <= DateTime.Now)
                throw new RefreshTokenExpiredException();
            
            if (user.RefreshToken != request.RefreshToken)
                throw new UnauthorizedException();

            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpireDateTime = DateTime.Now.AddMinutes(_authenticationConfiguration.TimeoutRefreshTokenMinutes);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new RefreshTokensViewModel()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
            };
        }
    }
}