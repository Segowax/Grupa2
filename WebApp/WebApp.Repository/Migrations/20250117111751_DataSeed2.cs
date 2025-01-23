using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: new Guid("e9cd1162-5a49-42f5-97aa-1d73dcf952d1"));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: new Guid("b18233d5-d2c5-4035-b5ac-833d5b131cb6"));
        }
    }
}
