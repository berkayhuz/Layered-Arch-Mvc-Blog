﻿// <auto-generated />
using System;
using HuzlabBlog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HuzlabBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231102143813_init923")]
    partial class init923
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9c1bd465-4ff6-437e-b43e-1f848fd26d99"),
                            ConcurrencyStamp = "8e196bd1-c3b2-45bf-aaf2-4899f27c9d88",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("68dfdd6b-a20b-498c-ad1d-b0eb12ae076a"),
                            ConcurrencyStamp = "e6b73cb0-4e68-4817-acb1-89ef0ec5ad97",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("cad1bc04-44bf-44b7-ade1-4d6b3fffcba7"),
                            ConcurrencyStamp = "e4d49cbd-2729-42eb-864c-2f9dc2e27227",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0572e551-68e4-4760-86dd-fe2593f7cb7c",
                            Email = "huzberkay@icloud.com",
                            EmailConfirmed = true,
                            FirstName = "Berkay",
                            ImageId = new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                            LastName = "Huz",
                            LockoutEnabled = false,
                            NormalizedEmail = "HUZBERKAY@ICLOUD.COM",
                            NormalizedUserName = "huzberkay@icloud.com",
                            PasswordHash = "AQAAAAIAAYagAAAAEM9b019bAjjDTRdiwmBmbIOSLmX8zl8oFtAjrCxIOqE19c9qRGd4zyo8rubBYsk3BA==",
                            PhoneNumber = "+905438018574",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fe2f0b19-5a51-4a68-a5b2-441cf27e9a16",
                            TwoFactorEnabled = false,
                            UserName = "huzberkay@icloud.com"
                        },
                        new
                        {
                            Id = new Guid("31feb16f-8c01-4e22-9a6f-df79b7e5582a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "562c2199-e7b2-48b6-b641-41f6b218801c",
                            Email = "hephizlimine@icloud.com",
                            EmailConfirmed = true,
                            FirstName = "Mine",
                            ImageId = new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                            LastName = "Hephızlı",
                            LockoutEnabled = false,
                            NormalizedEmail = "HEPHIZLIMINE@ICLOUD.COM",
                            NormalizedUserName = "HEPHIZLIMINE@ICLOUD.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEPos4H/1f0I/ygJRHDis6Ssl2RiJFiqPSkzKKFv/bIi6UQiJBNuSi+SGkrrdhSb4Q==",
                            PhoneNumber = "+905524130669",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "05764baa-21ac-4cc1-b901-0fe77bed1ac3",
                            TwoFactorEnabled = false,
                            UserName = "hephizlimine@icloud.com"
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                            RoleId = new Guid("9c1bd465-4ff6-437e-b43e-1f848fd26d99")
                        },
                        new
                        {
                            UserId = new Guid("31feb16f-8c01-4e22-9a6f-df79b7e5582a"),
                            RoleId = new Guid("68dfdd6b-a20b-498c-ad1d-b0eb12ae076a")
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ec94c0a-3aa9-4dc8-9c73-970a9adf0c1c"),
                            CategoryId = new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"),
                            Content = "Deneme Content",
                            CreatedBy = "Berkay Huz",
                            CreatedDate = new DateTime(2023, 11, 2, 17, 38, 12, 926, DateTimeKind.Local).AddTicks(6679),
                            ImageId = new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                            IsDeleted = false,
                            Title = "Asp.Net Core Deneme Makalesi 1",
                            UserId = new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.ArticleVisitor", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "VisitorId");

                    b.HasIndex("VisitorId");

                    b.ToTable("ArticleVisitors");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"),
                            CreatedBy = "Berkay Huz",
                            CreatedDate = new DateTime(2023, 11, 2, 17, 38, 12, 928, DateTimeKind.Local).AddTicks(3542),
                            IsDeleted = false,
                            Name = "ASP.NET Core"
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                            CreatedBy = "Berkay Huz",
                            CreatedDate = new DateTime(2023, 11, 2, 17, 38, 12, 928, DateTimeKind.Local).AddTicks(6411),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUser", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserClaim", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserLogin", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserRole", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuzlabBlog.Entities.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUserToken", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Article", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuzlabBlog.Entities.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("HuzlabBlog.Entities.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.ArticleVisitor", b =>
                {
                    b.HasOne("HuzlabBlog.Entities.Entities.Article", "Article")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HuzlabBlog.Entities.Entities.Visitor", "Visitor")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Article", b =>
                {
                    b.Navigation("ArticleVisitors");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HuzlabBlog.Entities.Entities.Visitor", b =>
                {
                    b.Navigation("ArticleVisitors");
                });
#pragma warning restore 612, 618
        }
    }
}
