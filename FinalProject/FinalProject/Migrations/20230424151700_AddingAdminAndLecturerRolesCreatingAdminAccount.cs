using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class AddingAdminAndLecturerRolesCreatingAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a2894e4-5dae-4590-b8e7-6b6c87237a97", "e0f2cd4a-c834-4c0e-b12d-1bd337a6822e", "Lecturer", "LECTURER" },
                    { "8a446ec2-7be7-46fc-9294-21b9355631cf", "ce8e1c1b-b99a-458b-b186-6b0dab71e1b5", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e14c9f14-4e73-4703-80a8-c9d1c131a2d5", 0, "Nigdjezemska 39", "764f76ca-b2a3-48b8-975b-22580c04e6a6", "siguran@mailfirme.com", false, "Siniša", "Administratovski", false, null, "SIGURAN@MAILFIRME.COM", "SIGURAN@MAILFIRME.COM", "AQAAAAEAACcQAAAAEDvXDgYKCmhyuWRDSg2TnADhyrB04dxQLM2KXrbXrAaV8vX6HXa9r1+f3oOSWZnhdw==", null, false, "06c11f08-892b-4ecb-a88a-1ff671c9b0f1", false, "siguran@mailfirme.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Instrukcije iz predmeta državne mature.", "", "Državna matura" },
                    { 2, "Instrukcije iz predmeta za osnovnu školu.", "", "Osnovna škola" },
                    { 3, "Instrukcije iz predmeta za srednju školu", "", "Srednja škola" },
                    { 4, "Glazba, programiranje, hobiji...", "", "Ostalo" }
                });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Bio", "ContactEmail", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Mato je ovdje kako bi Vam pomogao naučiti matematiku! Ima 35 godina i u slobodno vrijeme programira i svira gitaru.", "matomatematicar@gmail.com", "", "Mato Matematičar" },
                    { 2, "Hrvoje je apsolvent jednopredmetnog studija Hrvatskog jezika i književnosti na Filozofskom fakultetu u Zagrebu. Slobodno ga kontaktirajte sa bilo kakvim pitanjem o hrvatskom jeziku!", "hrvojehrvat@gmail.com", "", "Hrvoje Hrvat" },
                    { 3, "Pero je nastavnik na privatnom učilištu Privatus Maximus u Zagrebu, a u slobodno vrijeme drži instrukcije iz programskih jezika C++, C# i JavaScript.", "pero1337@gmail.com", "", "Pero Programer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a446ec2-7be7-46fc-9294-21b9355631cf", "e14c9f14-4e73-4703-80a8-c9d1c131a2d5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a2894e4-5dae-4590-b8e7-6b6c87237a97");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a446ec2-7be7-46fc-9294-21b9355631cf", "e14c9f14-4e73-4703-80a8-c9d1c131a2d5" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a446ec2-7be7-46fc-9294-21b9355631cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e14c9f14-4e73-4703-80a8-c9d1c131a2d5");
        }
    }
}
