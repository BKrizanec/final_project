using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class UpdateDataSeedPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "b969cdbf-a483-4748-b3a9-45a2cb7131de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "d9fd7dee-c91a-4640-85e8-6b85223696ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56142d66-5b2a-462b-9638-44122694b16c", "AQAAAAEAACcQAAAAEB1vdIjhyTZs2flTLtGeJd/xmKhmah4PkVMg3zUxV5frmgeBtd3W4NaLHS8WGTU4Pg==", "f59a19e4-8e22-4c66-96cf-8481cb515e07" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 13m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 17m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 13m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 9m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 16m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 11m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 13.55m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 12.33m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 13m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 40m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 18.32m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 9m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 30m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "eb1e2413-8d62-4a41-9a26-57b8e92889f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "6494cce2-ec7c-4137-8876-683a787baa9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73269cc-c6de-465f-ac59-a654a619716e", "AQAAAAEAACcQAAAAEFOA2vlPHPN2bIzZn7Iay5joaX55XL4XAR/TqLVBTAVaIs+dZ73nmbk0GhFZDr5Ftw==", "6bf84bec-861a-4fdb-abbd-bfc4c4ff2243" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 0m);
        }
    }
}
