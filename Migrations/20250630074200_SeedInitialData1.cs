using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sellyourcar.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 30, 0, 38, 38, 476, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 30, 0, 38, 38, 476, DateTimeKind.Local).AddTicks(4220));
        }
    }
}
