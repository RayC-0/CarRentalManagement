using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8544), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8562), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8567), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8568), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8955), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8956), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8959), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(8960), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9139), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9140), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9143), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9144), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9147), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9147), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9150), new DateTime(2025, 11, 24, 11, 35, 53, 91, DateTimeKind.Local).AddTicks(9151), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
