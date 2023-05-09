using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class UpdatedServiceCategoriesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "b16c8886-4a84-41bc-b679-6c8436062d46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "a0e4c726-2cdd-4f6c-b396-dcb9bc5e5a85");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d53dee0f-4f9e-4c9c-8657-7c350cd3619a", "AQAAAAEAACcQAAAAEGSJ8XjNGPcXU0iro3nac14ZMNo93IVI+Hla9xldVV/Exao5yWWk2BtzGMWx3hdwUw==", "d6522b45-2d27-41db-a04e-1f9d789840fa" });
        }
    }
}
