using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotoMondays.Migrations
{
    public partial class MotorcyclesAndInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Motorcycles_MotorcyclesMotorcycleID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceTickets_Employee_EmployeeID",
                table: "MaintenanceTickets");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceTickets_EmployeeID",
                table: "MaintenanceTickets");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_MotorcyclesMotorcycleID",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "MaintenanceTickets");

            migrationBuilder.DropColumn(
                name: "MotorcyclesMotorcycleID",
                table: "Inventories");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Motorcycles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "MotorcycleID",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "39a99185-b10c-489b-ab67-b906d90cbb47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f89fef1e-e52b-4f9d-98e9-20b8bc7d5b8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d7927823-94a9-418a-961b-d1e6780ff085");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f06b9418-dea5-4584-aab4-10e73ecadaa4", "AQAAAAEAACcQAAAAEFuoCBTwynmI402uQi27gSLdmXIyMqRBzx6HyzkU08bkq+bn/53oJ1462pcn+AuHow==", "941e9392-5add-4d63-98e0-21350d087402" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6176d98-7112-4e67-99d2-404d226e8ef6", "AQAAAAEAACcQAAAAEDY9KtIQ7649RSSQThREPN7WlfP1r0ckcTPU4urzsuU02GE1THhJ8rIm59BXcVM6gA==", "b0b08939-163a-46cc-83c0-e566412beb25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00caac02-a534-4bf8-b5e4-ba39ca0ca46f", "AQAAAAEAACcQAAAAEDHlAHzSc+59YKcG5O3paDZSudIR7+ylwyPb4jOEvtEGPiMod87nG8tV621LGygRvw==", "0a62dc85-d2f5-437f-820e-82a02f6f041a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2f837b-5ee2-4b8f-a7bf-727c06e175e3", "AQAAAAEAACcQAAAAEKul2b8R7yZACf+KiKDpTdf7odv46NS34WyG9iHZ12mK+HDhgUSmDaYiQyaeSmfwHg==", "2d65261e-20c0-4596-8e2e-7736b886bb2d" });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "MotorcycleID", "Manufacturer", "ModelType", "VINNumber", "Year" },
                values: new object[,]
                {
                    { 12, "Yamaha", "YZF-R6", "4S3YMHH68B2123456", "2006" },
                    { 27, "Suzuki", "GSXR600", "9B2SZKI72C3868341", "2015" }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleID", "ScheduleDays", "ScheduleHours", "UserID", "Wage" },
                values: new object[,]
                {
                    { 1, "MTWTF", "9-5", 1, 12.50m },
                    { 2, "MWT", "8-4", 2, 11.25m }
                });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "MotorcycleID",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "MotorcycleID",
                value: 27);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MotorcycleID",
                table: "Inventories",
                column: "MotorcycleID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_UserID",
                table: "Schedule",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Motorcycles_MotorcycleID",
                table: "Inventories",
                column: "MotorcycleID",
                principalTable: "Motorcycles",
                principalColumn: "MotorcycleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Motorcycles_MotorcycleID",
                table: "Inventories");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_MotorcycleID",
                table: "Inventories");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "MotorcycleID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "MotorcycleID",
                keyValue: 27);

            migrationBuilder.DropColumn(
                name: "MotorcycleID",
                table: "Inventories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "Motorcycles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "MaintenanceTickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorcyclesMotorcycleID",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employee_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "efbdedec-f79c-41d7-977e-c3c7272bbe21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "259a752a-98ad-4e00-a6bf-0804af34a758");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c9590341-309a-434c-b3ec-33dcdf86682a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ce2e9a-730b-4e5b-9d76-bd5acd157814", "AQAAAAEAACcQAAAAEO/jdiDVAHS2OjBU0p+HY19au8gmCOw8Ta+jSsbqtCn5N/2qIMefXjlclDwqYKKZLg==", "7d4a721d-c631-4e5e-9849-20444a74dec2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ac7472-b900-49d1-bf86-1bdd409df36e", "AQAAAAEAACcQAAAAEE8qYzL0cAyTNqIFE0UmzC1260h7f8gC3dVkg/hrSI/+8RCFqzCg6f+UdfTw5YEc+w==", "f8bc2deb-5118-4c30-b29f-f32ea5aa74b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c50b61f2-58b1-4901-b5ca-b98fd4c00986", "AQAAAAEAACcQAAAAEDJxn3ME3RnOIXEMSG2GySIcMCKYNA9XB8My0oNSsRZ+MFghMTu1W2UFyy0BRuchnQ==", "a99c498f-9269-4eb3-97ec-fb1c39224bc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd3603d7-ba03-46ed-97c1-e19c2a4b5dc2", "AQAAAAEAACcQAAAAEI031hTd7MQkT/Yav9SaQ85ELZMq05r6ji5UbsBfEIkkilwVCk7uO3YXXFJivnTs/Q==", "35488980-b2ab-454a-aaec-49b9eb8d39dd" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "ScheduleDays", "ScheduleHours", "UserId", "Wage" },
                values: new object[,]
                {
                    { 1, "MTWTF", "9-5", null, 12.50m },
                    { 2, "MWT", "8-4", null, 11.25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTickets_EmployeeID",
                table: "MaintenanceTickets",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MotorcyclesMotorcycleID",
                table: "Inventories",
                column: "MotorcyclesMotorcycleID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                table: "Employee",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Motorcycles_MotorcyclesMotorcycleID",
                table: "Inventories",
                column: "MotorcyclesMotorcycleID",
                principalTable: "Motorcycles",
                principalColumn: "MotorcycleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceTickets_Employee_EmployeeID",
                table: "MaintenanceTickets",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
