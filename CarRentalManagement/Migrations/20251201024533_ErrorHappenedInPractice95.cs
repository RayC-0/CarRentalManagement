using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class ErrorHappenedInPractice95 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a065cda1-1227-422d-91a7-776eb241c709", "AQAAAAIAAYagAAAAEAEA5zxLEwzRCpAAiTyCPdOx10WAing+VZ5Qbv+CkvTNr15Fc5o1C95I/igTQZof2A==", "8893c1ed-063c-4ba7-8521-f00740face17" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8025), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8045), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8476), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8479), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8625), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8628), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8631), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 12, 1, 10, 45, 32, 33, DateTimeKind.Local).AddTicks(8634) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e32d8189-6a81-4166-a623-00db95c102dc", "AQAAAAIAAYagAAAAEM+wQvfWktGMh+dFK7/yB8OYLgPUj2lm7yxeL6zOaMI3ZsZCJplsRplsP3KzrLlfzw==", "1d902658-c3ce-4b0b-a1c3-06d10ba632d8" });

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
        }
    }
}
