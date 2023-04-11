using Microsoft.EntityFrameworkCore.Migrations;

namespace MotoMondays.Migrations
{
    public partial class InventoryAndMaintenanceUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotorcycleID",
                table: "MaintenanceTickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotrocycleID",
                table: "MaintenanceTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d0d21d6b-929c-4a82-9d2c-781532cd9cc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "389bd79f-08b3-4b5f-a9b0-57caa15ca853");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a3e754f3-2519-4874-8a84-6e5b5daf893d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca6d880e-4eea-4ace-a5c2-13a16b4ea2bb", "AQAAAAEAACcQAAAAEJG5RXv5to29nzZtIsZHs0PiUyT6iZO7PrakS6XYu/a2bSw7eo6BCdppe2MAOeXBnQ==", "9bd90170-5d40-496a-b396-ebcf3d34f198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "743be053-ea87-4e58-b305-b003d1025fa7", "AQAAAAEAACcQAAAAEPSANrzXkmbynoVHb+2uTp7sWya/E9cBcbco6bSZJ6ZFra33QVpK8JJyX9mVPkiQHQ==", "57ca6ab2-1578-45a8-8379-7231c3c6782d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6600d95-fccd-43f9-9c90-cb6d84c6bc4c", "AQAAAAEAACcQAAAAEJy25E3DcY8oy9V8FjH6sA8yku3sDtx9ogGx8dDudknTPezXbtj6hEs3gjlIrhHQYQ==", "689fb4a5-8cba-4064-9603-f864fee741a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee6aad6-67e1-4007-890a-349b898f8a8c", "AQAAAAEAACcQAAAAEE+iR/5lDZOk+1py0TVWzJpbTjfSazP06AG0GBGyPwpMuPPD/O3LtzS+Pb3dvgIYIA==", "2d6850b4-92a0-464a-8dc9-57f8020c9a48" });

            migrationBuilder.UpdateData(
                table: "MaintenanceTickets",
                keyColumn: "MaintenanceTicketID",
                keyValue: 1,
                column: "MotrocycleID",
                value: 32);

            migrationBuilder.UpdateData(
                table: "MaintenanceTickets",
                keyColumn: "MaintenanceTicketID",
                keyValue: 2,
                column: "MotrocycleID",
                value: 29);

            migrationBuilder.UpdateData(
                table: "MaintenanceTickets",
                keyColumn: "MaintenanceTicketID",
                keyValue: 3,
                column: "MotrocycleID",
                value: 29);

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "MotorcycleID", "Manufacturer", "ModelType", "VINNumber", "Year" },
                values: new object[,]
                {
                    { 32, "Honda", "CBR-500RR", "5A2HNDA56K1536846", "2014" },
                    { 29, "Victory", "Gunner-1800", "8A6VCTY78R1684562", "2011" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTickets_MotorcycleID",
                table: "MaintenanceTickets",
                column: "MotorcycleID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceTickets_Motorcycles_MotorcycleID",
                table: "MaintenanceTickets",
                column: "MotorcycleID",
                principalTable: "Motorcycles",
                principalColumn: "MotorcycleID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceTickets_Motorcycles_MotorcycleID",
                table: "MaintenanceTickets");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceTickets_MotorcycleID",
                table: "MaintenanceTickets");

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "MotorcycleID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "MotorcycleID",
                keyValue: 32);

            migrationBuilder.DropColumn(
                name: "MotorcycleID",
                table: "MaintenanceTickets");

            migrationBuilder.DropColumn(
                name: "MotrocycleID",
                table: "MaintenanceTickets");

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
        }
    }
}
