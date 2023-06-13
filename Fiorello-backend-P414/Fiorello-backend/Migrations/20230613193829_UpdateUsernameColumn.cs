using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_backend.Migrations
{
    public partial class UpdateUsernameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 23, 38, 29, 687, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 23, 38, 29, 687, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 23, 38, 29, 687, DateTimeKind.Local).AddTicks(5222));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 13, 37, 45, 112, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 13, 37, 45, 112, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 13, 13, 37, 45, 112, DateTimeKind.Local).AddTicks(1470));
        }
    }
}
