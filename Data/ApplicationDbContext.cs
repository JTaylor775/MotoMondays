﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MotoMondays.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoMondays.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)   { }

        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<MaintenanceTicket> MaintenanceTickets { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new Role
                {
                    Id = 2,
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new Role
                {
                    Id = 3,
                    Name = "User",
                    NormalizedName = "USER"
                });

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    FirstName = "John",
                    MiddleName = "Dee",
                    LastName = "Doe",
                    Email = "jdoe@gmail.com",
                    PhoneNumber = "402-867-5309",
                    PasswordHash = hasher.HashPassword(null, "Password1"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                    Id = 2,
                    UserName = "employee",
                    NormalizedUserName = "EMPLOYEE",
                    FirstName = "Alex",
                    MiddleName = "Jones",
                    LastName = "Nelson",
                    Email = "anel@gmail.com",
                    PhoneNumber = "402-111-9999",
                    PasswordHash = hasher.HashPassword(null, "Password2"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                    Id = 3,
                    UserName = "customer",
                    NormalizedUserName = "CUSTOMER",
                    FirstName = "Bill",
                    MiddleName = "Bob",
                    LastName = "Barns",
                    Email = "bbarns@gmail.com",
                    PhoneNumber = "402-789-1234",
                    PasswordHash = hasher.HashPassword(null, "Password3"),
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new User
                {
                    Id = 4,
                    UserName = "user",
                    NormalizedUserName = "USER",
                    FirstName = "Zack",
                    MiddleName = "Jones",
                    LastName = "Rothson",
                    Email = "zrothson@gmail.com",
                    PhoneNumber = "402-222-8888",
                    PasswordHash = hasher.HashPassword(null, "Password4"),
                    SecurityStamp = Guid.NewGuid().ToString()
                });

            builder.Entity<IdentityUserRole<int>>().HasData(

               // RoleId 1 == Administrator, RoleId 2 == Employee, RoleId 3 == User
               new IdentityUserRole<int>
               {
                   RoleId = 1,
                   UserId = 1
               },
               new IdentityUserRole<int>
               {
                   RoleId = 2,
                   UserId = 2
               },
               new IdentityUserRole<int>
               {
                   RoleId = 3,
                   UserId = 3
               },
               new IdentityUserRole<int>
               {
                   RoleId = 3,
                   UserId = 4
               });

            builder.Entity<Schedule>().Property(e => e.Wage).HasColumnType("decimal(18,2)");
            builder.Entity<Inventory>().Property(i => i.Miles).HasColumnType("decimal(18,2)");

            builder.Entity<Schedule>().HasData(
                new Schedule(1, "MTWTF", "9-5", 12.50m, 1),
                new Schedule(2, "MWT", "8-4", 11.25m, 2));

            builder.Entity<Inventory>().HasData(
                new Inventory(1, 12, 100m, false),
                new Inventory(2, 27, 12000m, true));

            builder.Entity<MaintenanceTicket>().HasData(
                new MaintenanceTicket(1, "Oil Change", DateTime.Parse("03/25/2023"), false, 2, 32),
                new MaintenanceTicket(2, "Tire Change", DateTime.Parse("03/25/2023"), true, 2, 29),
                new MaintenanceTicket(3, "Transmition rebuild", DateTime.Parse("03/17/2023"), false, 4, 29));

            builder.Entity<Motorcycle>().HasData(
                new Motorcycle(12, "4S3YMHH68B2123456", "Yamaha", "YZF-R6","2006"),
                new Motorcycle(27, "9B2SZKI72C3868341", "Suzuki", "GSXR600","2015"),
                new Motorcycle(32, "5A2HNDA56K1536846", "Honda", "CBR-500RR", "2014"),
                new Motorcycle(29, "8A6VCTY78R1684562", "Victory", "Gunner-1800", "2011"));

            builder.Entity<Part>().HasData(
                new Part(10, "600cc Engine", true),
                new Part(20, "600cc transmission", true),
                new Part(30, "600cc Forks", false),
                new Part(32, "400cc Stunt Cage", true),
                new Part(40, "Road King Saddles Bag(Set)", false),
                new Part(45, "Harley Crank Shaft", true));
        }

        public DbSet<MotoMondays.Models.Schedule> Schedule { get; set; }
    }
}
