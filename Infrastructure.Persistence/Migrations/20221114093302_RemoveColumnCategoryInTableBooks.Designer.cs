﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(AdminApplicationDbContext))]
    [Migration("20221114093302_RemoveColumnCategoryInTableBooks")]
    partial class RemoveColumnCategoryInTableBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("AdminPermissions");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("AdminRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e36f983b-95cd-11eb-9cfc-5254000c2f33"),
                            Code = "SADMIN",
                            CreatedByAdminUserId = new Guid("62010f17-95cd-11eb-9cfc-5254000c2f33"),
                            CreatedDateTime = new DateTime(2022, 11, 13, 8, 47, 31, 256, DateTimeKind.Local).AddTicks(7253),
                            Name = "Администратор"
                        });
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminRoleAdminPermission", b =>
                {
                    b.Property<Guid>("AdminRoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminPermissionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("AdminRoleId", "AdminPermissionId");

                    b.HasIndex("AdminPermissionId");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("AdminRoleAdminPermissions");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastLogoutDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("PasswordExpireDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenExpireDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UpdatedByAdminUserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("AdminUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("62010f17-95cd-11eb-9cfc-5254000c2f33"),
                            CreatedDateTime = new DateTime(2022, 11, 13, 8, 47, 31, 256, DateTimeKind.Local).AddTicks(7253),
                            Email = "systemib@axl.com",
                            FirstName = "system",
                            IsActive = true,
                            LastName = "system",
                            Password = "123",
                            Username = "system"
                        },
                        new
                        {
                            Id = new Guid("101fda50-9084-11eb-aef2-244bfee059a7"),
                            CreatedByAdminUserId = new Guid("62010f17-95cd-11eb-9cfc-5254000c2f33"),
                            CreatedDateTime = new DateTime(2022, 11, 13, 8, 47, 31, 256, DateTimeKind.Local).AddTicks(7253),
                            Email = "admin@alx.com",
                            FirstName = "admin",
                            IsActive = true,
                            LastName = "admin",
                            Password = "123",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminUserAdminRole", b =>
                {
                    b.Property<Guid>("AdminUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminRoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("AdminUserId", "AdminRoleId");

                    b.HasIndex("AdminRoleId");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("AdminUserAdminRoles");

                    b.HasData(
                        new
                        {
                            AdminUserId = new Guid("101fda50-9084-11eb-aef2-244bfee059a7"),
                            AdminRoleId = new Guid("e36f983b-95cd-11eb-9cfc-5254000c2f33"),
                            CreatedByAdminUserId = new Guid("62010f17-95cd-11eb-9cfc-5254000c2f33"),
                            CreatedDateTime = new DateTime(2022, 11, 13, 8, 47, 31, 256, DateTimeKind.Local).AddTicks(7253),
                            Id = new Guid("0e4ce9f0-95d1-11eb-9f9c-244bfee059a7")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Authors.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("DeletedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("DeletedByUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Domain.Entities.Books.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Cover")
                        .HasColumnType("text");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("DeletedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("PageCount")
                        .HasColumnType("integer");

                    b.Property<short>("PublishYear")
                        .HasColumnType("smallint");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("DeletedByUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Domain.Entities.Books.BookCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.HasIndex("CategoryId", "BookId")
                        .IsUnique();

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("UpdatedByAdminUserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastLogoutDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("PasswordExpireDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenExpireDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedByAdminUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByAdminUserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UpdatedByAdminUserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Users.UserBookshelf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.HasIndex("UserId", "BookId")
                        .IsUnique();

                    b.ToTable("UserBookshelfs");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminRole", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminRoleAdminPermission", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminPermission", "AdminPermission")
                        .WithMany("AdminRoleAdminPermissions")
                        .HasForeignKey("AdminPermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminRole", "AdminRole")
                        .WithMany("AdminRoleAdminPermissions")
                        .HasForeignKey("AdminRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AdminPermission");

                    b.Navigation("AdminRole");

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminUser", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminUserAdminRole", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminRole", "AdminRole")
                        .WithMany("AdminUserAdminRoles")
                        .HasForeignKey("AdminRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "AdminUser")
                        .WithMany("AdminUserAdminRoles")
                        .HasForeignKey("AdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AdminRole");

                    b.Navigation("AdminUser");

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Authors.Author", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "DeletedByUser")
                        .WithMany()
                        .HasForeignKey("DeletedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("DeletedByUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Books.Book", b =>
                {
                    b.HasOne("Domain.Entities.Authors.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "DeletedByUser")
                        .WithMany()
                        .HasForeignKey("DeletedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Author");

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("DeletedByUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Books.BookCategory", b =>
                {
                    b.HasOne("Domain.Entities.Books.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Categories.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Book");

                    b.Navigation("Category");

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Categories.Category", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Users.User", b =>
                {
                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "CreatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("CreatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdminUsers.AdminUser", "UpdatedByAdminUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByAdminUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByAdminUser");

                    b.Navigation("UpdatedByAdminUser");
                });

            modelBuilder.Entity("Domain.Entities.Users.UserBookshelf", b =>
                {
                    b.HasOne("Domain.Entities.Books.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Users.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Users.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Users.User", "User")
                        .WithMany("Bookshelf")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminPermission", b =>
                {
                    b.Navigation("AdminRoleAdminPermissions");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminRole", b =>
                {
                    b.Navigation("AdminRoleAdminPermissions");

                    b.Navigation("AdminUserAdminRoles");
                });

            modelBuilder.Entity("Domain.Entities.AdminUsers.AdminUser", b =>
                {
                    b.Navigation("AdminUserAdminRoles");
                });

            modelBuilder.Entity("Domain.Entities.Authors.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Domain.Entities.Books.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Domain.Entities.Categories.Category", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Domain.Entities.Users.User", b =>
                {
                    b.Navigation("Bookshelf");
                });
#pragma warning restore 612, 618
        }
    }
}
