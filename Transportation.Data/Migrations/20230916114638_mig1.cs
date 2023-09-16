using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 56 QX 929", "Nathanial", "Langworth", "(250) 306-7885", 2, "(071) 570-4309" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "TR 47 PO 201", "Emerald", "Grady", "(368) 140-6680", 4, "(069) 253-1700" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 70 CF 437", "Jakob", "Mueller", "(633) 272-4847", 1, "(035) 149-1551" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 12 WK 720", "Gust", "Morissette", "(568) 299-1606", 2, "(035) 584-2270" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 68 LR 898", "Kole", "Spencer", "(241) 401-9649", 1, "(042) 765-1896" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2021, 4, 11, 14, 57, 21, 662, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2020, 12, 29, 22, 44, 13, 193, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2022, 6, 10, 22, 59, 16, 954, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2021, 8, 9, 10, 15, 36, 190, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Halvorson, Little and Wuckert Ulastirma", "HalvorsonLittleandWuckertUlastirma96@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Beier - Strosin Logistik", "Beier-StrosinLogistik20@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Lowe Inc Nakliyat", "LoweIncNakliyat.Hamill@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Thompson, Jacobson and Harvey Logistik", "ThompsonJacobsonandHarveyLogistik.Sawayn86@yahoo.com" });
        }
    }
}
