using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sellyourcar.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DatabaseViewModel",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 101, "devil is coming", new DateTime(2025, 6, 30, 0, 38, 38, 476, DateTimeKind.Local).AddTicks(4080), "God with Blue Heart" },
                    { 102, "Water raising", new DateTime(2025, 6, 30, 0, 38, 38, 476, DateTimeKind.Local).AddTicks(4220), "Black skyies with lighting" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "DatabaseViewModel",
                keyColumn: "Id",
                keyValue: 102);
        }
    }
}
