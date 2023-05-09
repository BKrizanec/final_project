using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class UpdateServiceCategoriesModelAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "c37191c2-5fda-436a-9dab-00fd4bb42e0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "1c286e39-0707-4e11-bcac-26d5a517240a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98aacf62-f182-4cea-99e6-68fdbb9f0f37", "AQAAAAEAACcQAAAAEKwp7+UKzz24MxDJFkdrp9Fiujw9gN+BlRQxihsVZMAKhttCAAql7F1ShZ4ml4CfQQ==", "6ef9275d-256f-4cd0-b7e5-44df90337250" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "e952cb1a-4f2c-4613-97f8-c248d958de02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "f9edd123-ee78-486a-8d88-5279d74912ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c37de765-cc94-45de-a645-c8012cdaea43", "AQAAAAEAACcQAAAAEGAU8qmMAqYhh86lQAH+CZgc5Rid46oCpRi3ItDrfxuNZ9b1iG72Q+4+dBUzB+dsjQ==", "7e22a560-1916-4d33-aec6-f1415c993fff" });
        }
    }
}
