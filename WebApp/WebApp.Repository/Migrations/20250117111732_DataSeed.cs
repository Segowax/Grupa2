using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Autor", "Guid", "Kategoria", "Tytul" },
                values: new object[,]
                {
                    { 1, "Adolf", new Guid("e9cd1162-5a49-42f5-97aa-1d73dcf952d1"), 1, "MeineKaumpf" },
                    { 2, "Adolf", new Guid("b18233d5-d2c5-4035-b5ac-833d5b131cb6"), 1, "MeineKaumpf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
