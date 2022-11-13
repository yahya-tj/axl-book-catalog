﻿using Domain.Enums.AdminUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Client.Common.Authorizations.Permission;

namespace WebApi.Client.Common.Extensions
{
    public static class AuthorizationExtension
    {
        public static IServiceCollection AddWebApiAuthorization(this IServiceCollection service)
        {
            service.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
            
            service.AddAuthorization(options =>
            {
                foreach (var (code, permissionEnum) in AdminPermissionEnum.Dictionary)
                {
                    options.AddPolicy(code, builder =>
                    {
                        builder.AddRequirements(new PermissionRequirement(permissionEnum.Value));
                    });
                }
            });

            return service;
        }
    }
}