using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class ChangedLecturerAsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97",
                column: "ConcurrencyStamp",
                value: "e0f2cd4a-c834-4c0e-b12d-1bd337a6822e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf",
                column: "ConcurrencyStamp",
                value: "ce8e1c1b-b99a-458b-b186-6b0dab71e1b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "764f76ca-b2a3-48b8-975b-22580c04e6a6", "AQAAAAEAACcQAAAAEDvXDgYKCmhyuWRDSg2TnADhyrB04dxQLM2KXrbXrAaV8vX6HXa9r1+f3oOSWZnhdw==", "06c11f08-892b-4ecb-a88a-1ff671c9b0f1" });
        }
    }
}
