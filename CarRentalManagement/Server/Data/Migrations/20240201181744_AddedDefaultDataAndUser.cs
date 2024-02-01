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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "132763a8-6893-498d-8a77-0298390814c2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDvhznnrqp+iCp0ry4i50NSGMf6at14SIz3yIS4+Gb/AXBtWV+TxtHoCQJKQDrxjlA==", null, false, "c1ba1dac-0731-4e17-a830-798cddee8f3f", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8062), "Black", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8069), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8731), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(8735), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9207), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9212), "X5", "System" },
                    { 3, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9214), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9215), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 2, 2, 2, 17, 44, 226, DateTimeKind.Local).AddTicks(9219), "Rav4", "System" }
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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
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
