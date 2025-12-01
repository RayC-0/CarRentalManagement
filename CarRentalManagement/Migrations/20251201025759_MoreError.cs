using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class MoreError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5e5ab0-fd58-4e4c-8c37-cd2fa4e2ea48", "AQAAAAIAAYagAAAAELHbn+vNqiBR9RSOKSMXuSoINOwj4Y5rr+69bQE6hbHIIEyCMca6hVZqYZt2cojoSw==", "3ffb6b36-14fa-4b0b-af85-dfe6f50b3bc5" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(5805), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6158), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6162), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6326), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6330), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6333), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6336), new DateTime(2025, 12, 1, 10, 57, 58, 596, DateTimeKind.Local).AddTicks(6337) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
