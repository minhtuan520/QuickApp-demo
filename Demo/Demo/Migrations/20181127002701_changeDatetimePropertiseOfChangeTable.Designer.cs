﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Migrations
{
    [DbContext(typeof(tkbremake4DbContext))]
    [Migration("20181127002701_changeDatetimePropertiseOfChangeTable")]
    partial class changeDatetimePropertiseOfChangeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Account", b =>
                {
                    b.Property<string>("User")
                        .HasColumnName("USER")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Inf")
                        .HasColumnName("INF")
                        .HasMaxLength(132);

                    b.Property<string>("Pass")
                        .HasColumnName("PASS")
                        .HasMaxLength(30);

                    b.HasKey("User");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ACCOUNT");
                });

            modelBuilder.Entity("DAL.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("DAL.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Configuration");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("JobTitle");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DAL.Models.Change", b =>
                {
                    b.Property<string>("User")
                        .HasColumnName("USER")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Time")
                        .HasColumnName("TIME")
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<string>("Action")
                        .HasColumnName("ACTION")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Target")
                        .HasColumnName("TARGET")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.HasKey("User", "Time", "Action", "Target");

                    b.ToTable("CHANGE");
                });

            modelBuilder.Entity("DAL.Models.Dieukien", b =>
                {
                    b.Property<string>("Gv")
                        .HasColumnName("GV")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Mh")
                        .HasColumnName("MH")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("L")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<short>("Tiet")
                        .HasColumnName("TIET");

                    b.Property<short>("Thu")
                        .HasColumnName("THU");

                    b.HasKey("Gv", "Mh", "L", "Tiet", "Thu");

                    b.ToTable("DIEUKIEN");
                });

            modelBuilder.Entity("DAL.Models.Giaovien", b =>
                {
                    b.Property<string>("Gv")
                        .HasColumnName("GV")
                        .HasMaxLength(5);

                    b.Property<string>("Ho")
                        .HasColumnName("HO")
                        .HasMaxLength(30);

                    b.Property<string>("Inf")
                        .HasColumnName("INF")
                        .HasMaxLength(50);

                    b.Property<string>("Ten")
                        .HasColumnName("TEN")
                        .HasMaxLength(30);

                    b.HasKey("Gv");

                    b.ToTable("GIAOVIEN");
                });

            modelBuilder.Entity("DAL.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Hieuluc")
                        .HasColumnName("HIEULUC")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Gv")
                        .HasColumnName("GV")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Mh")
                        .HasColumnName("MH")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("L")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<int>("Tiet")
                        .HasColumnName("TIET");

                    b.HasKey("Id", "Hieuluc", "Gv", "Mh", "L", "Tiet");

                    b.ToTable("LOG");
                });

            modelBuilder.Entity("DAL.Models.Lop", b =>
                {
                    b.Property<string>("L")
                        .HasMaxLength(5);

                    b.HasKey("L");

                    b.ToTable("LOP");
                });

            modelBuilder.Entity("DAL.Models.Monhoc", b =>
                {
                    b.Property<string>("Mh")
                        .HasColumnName("MH")
                        .HasMaxLength(5);

                    b.Property<short?>("Cb")
                        .HasColumnName("CB");

                    b.Property<short?>("Lap")
                        .HasColumnName("LAP");

                    b.Property<string>("Ten")
                        .HasColumnName("TEN")
                        .HasMaxLength(30);

                    b.HasKey("Mh");

                    b.ToTable("MONHOC");
                });

            modelBuilder.Entity("DAL.Models.Phancong", b =>
                {
                    b.Property<string>("Gv")
                        .HasColumnName("GV")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Mh")
                        .HasColumnName("MH")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("L")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.HasKey("Gv", "Mh", "L");

                    b.ToTable("PHANCONG");
                });

            modelBuilder.Entity("DAL.Models.Tkb", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Hieuluc")
                        .HasColumnName("HIEULUC")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Gv")
                        .HasColumnName("GV")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Mh")
                        .HasColumnName("MH")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("L")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<short>("Tiet")
                        .HasColumnName("TIET");

                    b.Property<short>("Thu")
                        .HasColumnName("THU");

                    b.HasKey("Id", "Hieuluc", "Gv", "Mh", "L", "Tiet", "Thu");

                    b.ToTable("TKB");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<string>("ClientSecret");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("ConsentType");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Permissions");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("Properties");

                    b.Property<string>("RedirectUris");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Properties");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Properties");

                    b.Property<string>("Resources");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken();

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Payload");

                    b.Property<string>("Properties");

                    b.Property<string>("ReferenceId");

                    b.Property<string>("Status");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId")
                        .IsUnique()
                        .HasFilter("[ReferenceId] IS NOT NULL");

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("DAL.Models.Account", b =>
                {
                    b.HasOne("DAL.Models.ApplicationUser")
                        .WithMany("Account")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("DAL.Models.ApplicationRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("DAL.Models.ApplicationRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
