using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotoMondays.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    MotorcycleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VINNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.MotorcycleID);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    PartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.PartID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedule_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorcycleID = table.Column<int>(type: "int", nullable: false),
                    Miles = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreOwned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_Inventories_Motorcycles_MotorcycleID",
                        column: x => x.MotorcycleID,
                        principalTable: "Motorcycles",
                        principalColumn: "MotorcycleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTickets",
                columns: table => new
                {
                    MaintenanceTicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MotorcycleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceTickets", x => x.MaintenanceTicketID);
                    table.ForeignKey(
                        name: "FK_MaintenanceTickets_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MaintenanceTickets_Motorcycles_MotorcycleID",
                        column: x => x.MotorcycleID,
                        principalTable: "Motorcycles",
                        principalColumn: "MotorcycleID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 3, "3a552cb6-26b0-4615-a21f-c89ecb339b0d", "User", "USER" },
                    { 2, "de740e3b-d59b-49b7-aa45-6dde6ac9445c", "Employee", "EMPLOYEE" },
                    { 1, "e2a63a02-ff18-4a5b-bf89-02c24702e04f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "7692ad2e-014e-4b2f-bc14-a52a63901e08", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zrothson@gmail.com", false, "Zack", "Rothson", false, null, "Jones", null, "USER", "AQAAAAEAACcQAAAAELzA1I2AhYGkWPU+oHiQgrTmZq0cJBXP3gfWYEO3n7QXMDxwAGBUKqNM2NIxPm3j7Q==", "402-222-8888", false, "52d47587-58bd-40a7-91d3-3d3daccb22fe", false, "user" },
                    { 2, 0, "675f8c0f-08b7-48f4-b01e-5b3e648645ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "anel@gmail.com", false, "Alex", "Nelson", false, null, "Jones", null, "EMPLOYEE", "AQAAAAEAACcQAAAAEBcwnEOWwiKWWJOFC8S6pdvKuCN/BpLRY3Zq+bsS0ulm+BF3qhXoEFbs3sk1mWvqFA==", "402-111-9999", false, "6870faeb-6dbd-4d17-b947-ce4552424ee1", false, "employee" },
                    { 1, 0, "340a08b3-cbb5-4ac7-9772-2a11a9935ba5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdoe@gmail.com", false, "John", "Doe", false, null, "Dee", null, "ADMIN", "AQAAAAEAACcQAAAAEP7U4oqcuy2xV5C9yAH0l2zhQK1WFCnJydlMMmka7AqwmMglQWKeUTT6IOTlV90/mw==", "402-867-5309", false, "fe8e754c-4bd3-4964-94ab-30b0af7565c1", false, "admin" },
                    { 3, 0, "fd007706-2de3-418f-ba9c-528fd2d553d1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bbarns@gmail.com", false, "Bill", "Barns", false, null, "Bob", null, "CUSTOMER", "AQAAAAEAACcQAAAAEH0GrTL3P8gXW5YjqFQNnhn5jYIWTp33WHrigxmVwkMcNI8ZcuHLKZsJ1gsdGGv9bw==", "402-789-1234", false, "d31d14d3-8e14-46d2-b72d-de8c7482cf3d", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "MotorcycleID", "Manufacturer", "ModelType", "VINNumber", "Year" },
                values: new object[,]
                {
                    { 12, "Yamaha", "YZF-R6", "4S3YMHH68B2123456", "2006" },
                    { 29, "Victory", "Gunner-1800", "8A6VCTY78R1684562", "2011" },
                    { 32, "Honda", "CBR-500RR", "5A2HNDA56K1536846", "2014" },
                    { 27, "Suzuki", "GSXR600", "9B2SZKI72C3868341", "2015" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartID", "InStock", "PartName" },
                values: new object[,]
                {
                    { 30, false, "600cc Forks" },
                    { 45, true, "Harley Crank Shaft" },
                    { 20, true, "600cc transmission" },
                    { 10, true, "600cc Engine" },
                    { 32, true, "400cc Stunt Cage" },
                    { 40, false, "Road King Saddles Bag(Set)" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "Miles", "MotorcycleID", "PreOwned" },
                values: new object[,]
                {
                    { 1, 100m, 12, false },
                    { 2, 12000m, 27, true }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceTickets",
                columns: new[] { "MaintenanceTicketID", "Completed", "DateSubmitted", "MotorcycleID", "TicketDescription", "UserID" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Oil Change", 2 },
                    { 2, true, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Tire Change", 2 },
                    { 3, false, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Transmition rebuild", 4 }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleID", "ScheduleDays", "ScheduleHours", "UserID", "Wage" },
                values: new object[,]
                {
                    { 1, "MTWTF", "9-5", 1, 12.50m },
                    { 2, "MWT", "8-4", 2, 11.25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MotorcycleID",
                table: "Inventories",
                column: "MotorcycleID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTickets_MotorcycleID",
                table: "MaintenanceTickets",
                column: "MotorcycleID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTickets_UserID",
                table: "MaintenanceTickets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_UserID",
                table: "Schedule",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "MaintenanceTickets");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
