using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "ProductImages");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "8bb18675-7eb2-41c1-bf85-4e3fbfde2afc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60a0bea0-a428-4029-961e-1293c6c05922", "AQAAAAEAACcQAAAAEM3Gs++UeI/LQEDndDmAqrZO1LEIawrpcTIJL3e+2/ng2x+5LtdkluUgn8k1QM0m2g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 10, 16, 40, 50, 769, DateTimeKind.Local).AddTicks(4362));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2a0482bb-3cbb-4b97-acb6-0de61e5c03d1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b495f63-d439-4443-aa5c-676addb5987b", "AQAAAAEAACcQAAAAEOUFy+6Am6PNaE3S5n3Jnu96CGOCXp8ml9xDtEkjXQ8iNJNn2Hx43PYJu1WB3Kqd2Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 6, 9, 11, 30, 26, 849, DateTimeKind.Local).AddTicks(1137));
        }
    }
}
