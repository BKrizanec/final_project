using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class UpdatedLecturerDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "f6122ec7-93cc-41bb-a825-ffb22f28ca64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "599b0fe3-2d66-4528-bfff-08c0b2ecfd50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03d277a9-7477-48c6-a39a-fa9b49f289fd", "AQAAAAEAACcQAAAAEHRR5Lft+KLu0+ADIvOlD+2jFDYNK/DRsm5kuO+DfLsxZs9VgH27BCown3JxgRnsxw==", "2021b1cd-efc8-41eb-94a4-aff9c1e27534" });
        }
    }
}
