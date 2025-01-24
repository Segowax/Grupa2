using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class item : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("e5e9debd-825c-4604-b8de-f53bceea17b4"));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("7c1b69c3-3045-49cf-960d-eee8c2968770"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("608ef04e-5dbe-40cb-ad41-8f9b43ac45b5"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("accf3729-cc66-4b2b-a6ea-0056f0c1fd3b"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Guid", "Name" },
                values: new object[] { 3, "Description", new Guid("05f6d081-fcfd-4bfa-b964-d719cb84a741"), "ututut" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("f5af9cfb-caa7-4f7f-8223-5a1f15e5b073"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("814dde23-05d8-4fab-87a7-00d0f305e315"));
        }
    }
}
