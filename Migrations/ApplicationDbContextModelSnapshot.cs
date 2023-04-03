﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotoMondays.Data;

namespace MotoMondays.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MotoMondays.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Miles")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MotorcycleID")
                        .HasColumnType("int");

                    b.Property<bool>("PreOwned")
                        .HasColumnType("bit");

                    b.HasKey("InventoryId");

                    b.HasIndex("MotorcycleID");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            Miles = 100m,
                            MotorcycleID = 12,
                            PreOwned = false
                        },
                        new
                        {
                            InventoryId = 2,
                            Miles = 12000m,
                            MotorcycleID = 27,
                            PreOwned = true
                        });
                });

            modelBuilder.Entity("MotoMondays.Models.MaintenanceTicket", b =>
                {
                    b.Property<int>("MaintenanceTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("TicketDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MaintenanceTicketID");

                    b.HasIndex("UserID");

                    b.ToTable("MaintenanceTickets");

                    b.HasData(
                        new
                        {
                            MaintenanceTicketID = 1,
                            Completed = false,
                            DateSubmitted = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TicketDescription = "Oil Change",
                            UserID = 2
                        },
                        new
                        {
                            MaintenanceTicketID = 2,
                            Completed = true,
                            DateSubmitted = new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TicketDescription = "Tire Change",
                            UserID = 2
                        },
                        new
                        {
                            MaintenanceTicketID = 3,
                            Completed = false,
                            DateSubmitted = new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TicketDescription = "Transmition rebuild",
                            UserID = 4
                        });
                });

            modelBuilder.Entity("MotoMondays.Models.Motorcycle", b =>
                {
                    b.Property<int>("MotorcycleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VINNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MotorcycleID");

                    b.ToTable("Motorcycles");

                    b.HasData(
                        new
                        {
                            MotorcycleID = 12,
                            Manufacturer = "Yamaha",
                            ModelType = "YZF-R6",
                            VINNumber = "4S3YMHH68B2123456",
                            Year = "2006"
                        },
                        new
                        {
                            MotorcycleID = 27,
                            Manufacturer = "Suzuki",
                            ModelType = "GSXR600",
                            VINNumber = "9B2SZKI72C3868341",
                            Year = "2015"
                        });
                });

            modelBuilder.Entity("MotoMondays.Models.Part", b =>
                {
                    b.Property<int>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("MotoMondays.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "39a99185-b10c-489b-ab67-b906d90cbb47",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "f89fef1e-e52b-4f9d-98e9-20b8bc7d5b8b",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "d7927823-94a9-418a-961b-d1e6780ff085",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("MotoMondays.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScheduleDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScheduleHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<decimal>("Wage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ScheduleID");

                    b.HasIndex("UserID");

                    b.ToTable("Schedule");

                    b.HasData(
                        new
                        {
                            ScheduleID = 1,
                            ScheduleDays = "MTWTF",
                            ScheduleHours = "9-5",
                            UserID = 1,
                            Wage = 12.50m
                        },
                        new
                        {
                            ScheduleID = 2,
                            ScheduleDays = "MWT",
                            ScheduleHours = "8-4",
                            UserID = 2,
                            Wage = 11.25m
                        });
                });

            modelBuilder.Entity("MotoMondays.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f06b9418-dea5-4584-aab4-10e73ecadaa4",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jdoe@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            MiddleName = "Dee",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEFuoCBTwynmI402uQi27gSLdmXIyMqRBzx6HyzkU08bkq+bn/53oJ1462pcn+AuHow==",
                            PhoneNumber = "402-867-5309",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "941e9392-5add-4d63-98e0-21350d087402",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6176d98-7112-4e67-99d2-404d226e8ef6",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anel@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alex",
                            LastName = "Nelson",
                            LockoutEnabled = false,
                            MiddleName = "Jones",
                            NormalizedUserName = "EMPLOYEE",
                            PasswordHash = "AQAAAAEAACcQAAAAEDY9KtIQ7649RSSQThREPN7WlfP1r0ckcTPU4urzsuU02GE1THhJ8rIm59BXcVM6gA==",
                            PhoneNumber = "402-111-9999",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b0b08939-163a-46cc-83c0-e566412beb25",
                            TwoFactorEnabled = false,
                            UserName = "employee"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00caac02-a534-4bf8-b5e4-ba39ca0ca46f",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bbarns@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bill",
                            LastName = "Barns",
                            LockoutEnabled = false,
                            MiddleName = "Bob",
                            NormalizedUserName = "CUSTOMER",
                            PasswordHash = "AQAAAAEAACcQAAAAEDHlAHzSc+59YKcG5O3paDZSudIR7+ylwyPb4jOEvtEGPiMod87nG8tV621LGygRvw==",
                            PhoneNumber = "402-789-1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0a62dc85-d2f5-437f-820e-82a02f6f041a",
                            TwoFactorEnabled = false,
                            UserName = "customer"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c2f837b-5ee2-4b8f-a7bf-727c06e175e3",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "zrothson@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Zack",
                            LastName = "Rothson",
                            LockoutEnabled = false,
                            MiddleName = "Jones",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEKul2b8R7yZACf+KiKDpTdf7odv46NS34WyG9iHZ12mK+HDhgUSmDaYiQyaeSmfwHg==",
                            PhoneNumber = "402-222-8888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2d65261e-20c0-4596-8e2e-7736b886bb2d",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MotoMondays.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MotoMondays.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MotoMondays.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MotoMondays.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotoMondays.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MotoMondays.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MotoMondays.Models.Inventory", b =>
                {
                    b.HasOne("MotoMondays.Models.Motorcycle", "Motorcycles")
                        .WithMany()
                        .HasForeignKey("MotorcycleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Motorcycles");
                });

            modelBuilder.Entity("MotoMondays.Models.MaintenanceTicket", b =>
                {
                    b.HasOne("MotoMondays.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MotoMondays.Models.Schedule", b =>
                {
                    b.HasOne("MotoMondays.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
