using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class FinalDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta za osnovnu školu.", "Osnovna škola" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta za srednju školu", "Srednja škola" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta državne mature.", "Državna matura" });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Bio", "ContactEmail", "Image", "Title" },
                values: new object[,]
                {
                    { 4, "Siniša je oduvijek gajio interes prema tehničkim predmetima, te je voljan svoje znanje podijeliti sa drugima.", "siniša@gmail.com", "", "Siniša Sistemac" },
                    { 5, "Dino je oduvijek volio dizajn, te je svoj hobi odlučio pretvoriti u posao. U slobodno vrijeme poučava sve od modeliranja do dizajna korisničkih sučelja.", "dino23@gmail.com", "", "Dino Dizajnerić" },
                    { 6, "Hinko je završio Filozofski fakultet  i spreman je pomoći svima koji trebaju pomoć sa humanističkim znanostima! Doktorand moderne povijesti.", "hinkovski@gmail.com", "", "Hinko Humanist" },
                    { 7, "Dražen je asistent na Pravnom fakultetu, a u slobodno vrijeme se bavi sa instrukcijama.", "draz3993@gmail.com", "", "Dražen Društvenjak" },
                    { 8, "Jelena je pravi poliglot, te je sa svojih 25 godina naučila 5 jezika.", "jeja111@gmail.com", "", "Jelena Jezičarka" },
                    { 9, "Timotej je oduvijek bio zainteresiran za robotiku, a sada paralelno sa poslom drži instrukcije na ovoj maloj stranici.", "timon@gmail.com", "", "Timotej Tehničarovski" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "LecturerId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Instrukcije iz hrvatskog jezika za osnovnu školu.", 2, 0m, "Hrvatski jezik" },
                    { 4, "Instrukcije iz matematike za osnovnu školu.", 1, 0m, "Matematika" },
                    { 10, "Instrukcije iz sviranja gitare za početnike.", 1, 0m, "Gitara" },
                    { 11, "Instrukcije iz sviranja bubnjeva za početnike.", 1, 0m, "Bubnjevi" },
                    { 12, "Instrukcije iz C# i Jave za početnike.", 3, 0m, "Back-end development" },
                    { 15, "Instrukcije iz elektrotehnike za srednju tehničku školu.", 1, 0m, "Elektrotehnika" },
                    { 16, "Instrukcije iz latinskog jezika za srednju školu.", 1, 0m, "Latinski jezik" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "Id", "CategoryId", "ServiceId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 1, 4 },
                    { 10, 4, 10 },
                    { 11, 4, 11 },
                    { 12, 4, 12 },
                    { 15, 2, 15 },
                    { 16, 2, 16 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "LecturerId", "Price", "Title" },
                values: new object[,]
                {
                    { 2, "Instrukcije iz engleskog jezika za srednju školu.", 8, 0m, "Engleski jezik" },
                    { 3, "Instrukcije iz povijesti za osnovnu školu.", 6, 0m, "Povijest" },
                    { 5, "Instrukcije iz njemačkog jezika za srednju školu.", 8, 0m, "Njemački jezik" },
                    { 6, "Instrukcije iz talijanskog jezika za srednju školu.", 8, 0m, "Talijanski jezik" },
                    { 7, "Instrukcije iz biologije za državnu maturu.", 7, 0m, "Biologija" },
                    { 8, "Instrukcije iz fizike za državnu maturu.", 9, 0m, "Fizika" },
                    { 9, "Instrukcije iz kemije za državnu maturu.", 7, 0m, "Kemija" },
                    { 13, "Instrukcije iz Figme i principa etičkog dizajna.", 5, 0m, "UX/UI dizajn" },
                    { 14, "Instrukcije iz dizajna video-igara i teorijska podloga.", 5, 0m, "Dizajn video-igara" },
                    { 17, "Instrukcije iz 3D dizajna u Blenderu", 5, 0m, "3D dizajn" },
                    { 18, "Instrukcije iz informatike za osnovnu školu.", 4, 0m, "Informatika" },
                    { 19, "Instrukcije iz tehničke kulture za osnovnu školu.", 9, 0m, "Tehnička kultura" },
                    { 20, "Instrukcije iz sistemske podrške za srednju strukovnu školu.", 4, 0m, "Sistemska podrška" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "Id", "CategoryId", "ServiceId" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 3, 1, 3 },
                    { 5, 2, 5 },
                    { 6, 2, 6 },
                    { 7, 3, 7 },
                    { 8, 3, 8 },
                    { 9, 3, 9 },
                    { 13, 4, 13 },
                    { 14, 4, 14 },
                    { 17, 4, 17 },
                    { 18, 1, 18 },
                    { 19, 1, 19 },
                    { 20, 2, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta državne mature.", "Državna matura" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta za osnovnu školu.", "Osnovna škola" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Instrukcije iz predmeta za srednju školu", "Srednja škola" });
        }
    }
}
