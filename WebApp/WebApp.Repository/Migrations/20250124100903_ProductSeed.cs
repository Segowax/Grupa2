using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("c6222742-2af4-45ce-aaf7-a170b90badd1"));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("a7569fde-9114-4e8b-b420-49da01967ea3"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Guid", "Name" },
                values: new object[,]
                {
                    { 1, "Description", new Guid("f5af9cfb-caa7-4f7f-8223-5a1f15e5b073"), "Name" },
                    { 2, "Description", new Guid("814dde23-05d8-4fab-87a7-00d0f305e315"), "Mimi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("ba0295ba-428e-456a-9fb1-7d513015bf49"));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("51e4ec51-dc76-4104-9cf7-a93b8ba6080a"));
        }
    }
}
