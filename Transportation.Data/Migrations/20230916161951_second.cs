using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68b9679a-f507-4094-9066-19cb0713e1d8", "dadc3d4d-9bf1-4921-9bb8-c9c67d21421a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68b9679a-f507-4094-9066-19cb0713e1d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dadc3d4d-9bf1-4921-9bb8-c9c67d21421a");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 65 EW 457", "Laurence", "Strosin", "(266) 894-1520", 1, "(023) 425-4748" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 20 JN 182", "Urban", "Murray", "(378) 400-9151", "(064) 432-4919" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 59 PT 941", "Devyn", "Weber", "(854) 453-6259", 3, "(040) 764-6649" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 62 XB 730", "Tamia", "Hyatt", "(906) 677-9319", 2, "(044) 239-0676" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3a04333-bca2-4fea-a0ef-5c334c79de81", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b91f23f9-c4dc-4aa3-b1b5-27b3d8699556", 0, "3b55ad96-259e-4dfb-ba26-1e9514dda4c1", "admin@qwe.com", false, false, null, null, null, null, null, false, "b9787754-8f19-4694-92a9-f1b84d6d33c5", 0L, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2021, 5, 6, 10, 36, 44, 706, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2022, 2, 12, 10, 34, 49, 948, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2021, 1, 26, 15, 27, 49, 879, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2021, 10, 18, 14, 56, 46, 853, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Yost, Stamm and Wilderman Nakliyat", "YostStammandWildermanNakliyat9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Klocko - Nienow Ulastirma", "Klocko-NienowUlastirma_Kub@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Ebert, Bruen and Nicolas Nakliyat", "EbertBruenandNicolasNakliyat32@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Hackett - Ziemann Ulastirma", "Hackett-ZiemannUlastirma_Bayer86@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3a04333-bca2-4fea-a0ef-5c334c79de81", "b91f23f9-c4dc-4aa3-b1b5-27b3d8699556" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3a04333-bca2-4fea-a0ef-5c334c79de81", "b91f23f9-c4dc-4aa3-b1b5-27b3d8699556" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3a04333-bca2-4fea-a0ef-5c334c79de81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b91f23f9-c4dc-4aa3-b1b5-27b3d8699556");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 52 XW 602", "Precious", "Stanton", "(555) 979-8769", 3, "(069) 106-2504" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 56 QX 929", "Nathanial", "Langworth", "(250) 306-7885", "(071) 570-4309" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 62 PC 700", "Donald", "Davis", "(317) 712-1572", 1, "(028) 492-0754" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 23 BF 485", "Maci", "Romaguera", "(510) 003-3934", 3, "(081) 505-6758" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68b9679a-f507-4094-9066-19cb0713e1d8", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dadc3d4d-9bf1-4921-9bb8-c9c67d21421a", 0, "cbccbe2d-c0a0-4a70-a021-a94b6b77b3aa", "admin@qwe.com", false, false, null, null, null, null, null, false, "80355ad4-56d8-4b88-bea6-ffa1e2e860b2", 0L, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2021, 5, 3, 12, 23, 29, 629, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2020, 12, 15, 17, 20, 41, 314, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2023, 3, 20, 8, 5, 41, 796, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2021, 10, 6, 2, 3, 29, 68, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Kuhn - Berge Logistik", "Kuhn-BergeLogistik_Krajcik55@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Leffler, Hoeger and Mayert Nakliyat", "LefflerHoegerandMayertNakliyat_Beier@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Yundt, Johnson and Gleichner Logistik", "YundtJohnsonandGleichnerLogistik.Mitchell@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Kris and Sons Logistik", "KrisandSonsLogistik_Hilll82@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "68b9679a-f507-4094-9066-19cb0713e1d8", "dadc3d4d-9bf1-4921-9bb8-c9c67d21421a" });
        }
    }
}
