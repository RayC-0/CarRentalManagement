using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e32d8189-6a81-4166-a623-00db95c102dc", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEM+wQvfWktGMh+dFK7/yB8OYLgPUj2lm7yxeL6zOaMI3ZsZCJplsRplsP3KzrLlfzw==", null, false, "1d902658-c3ce-4b0b-a1c3-06d10ba632d8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3189), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3205), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3461), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3464), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3569), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3571), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3573), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3575), new DateTime(2025, 11, 26, 10, 8, 35, 775, DateTimeKind.Local).AddTicks(3575) });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9073), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9093), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9432), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9435), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9582), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9585), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9588), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9590), new DateTime(2025, 11, 26, 9, 37, 11, 450, DateTimeKind.Local).AddTicks(9591) });
        }
    }
}
