using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "687a7ccf-c797-47a5-b353-0c965c71ff34", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAtv7qP6jnuRM01LQSp0r09Ev8gwgOiPaDUnZMlORCVgK8kGU51nY3SmIuPP0b8b/A==", null, false, "a8b5bed2-4855-4713-be09-2c42d2733ca3", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(8907), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(8910), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9182), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9184), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9324), "3 series", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9326), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9328), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 11, 23, 15, 14, 17, 292, DateTimeKind.Local).AddTicks(9329), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
