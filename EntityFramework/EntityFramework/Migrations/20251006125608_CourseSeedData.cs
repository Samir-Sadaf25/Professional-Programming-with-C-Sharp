using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CourseSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "ClassStartDate", "CourseId", "Fees", "Name" },
                values: new object[,]
                {
                    { -2, new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 30000.0, "Dot net" },
                    { -1, new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 8000.0, "C#" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
