using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 12 WK 720", "Gust", "Morissette", "(568) 299-1606", "(035) 584-2270" });

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
                column: "TalepTarihi",
                value: new DateTime(2021, 4, 11, 14, 57, 21, 662, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2020, 12, 29, 22, 44, 13, 193, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2022, 6, 10, 22, 59, 16, 954, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2021, 8, 9, 10, 15, 36, 190, DateTimeKind.Local).AddTicks(6349) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 46 DR 068", "Esta", "Lemke", "(611) 587-7749", 1, "(054) 655-1589" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 61 SQ 602", "Francisca", "Cassin", "(029) 741-3462", 2, "(011) 733-3169" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 64 HU 068", "Ocie", "Glover", "(205) 962-7343", "(040) 048-7244" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 51 BE 926", "Angelita", "Rolfson", "(735) 593-3785", 4, "(094) 569-4291" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2023, 1, 1, 0, 0, 43, 817, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2023, 5, 17, 15, 1, 52, 921, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2022, 8, 2, 12, 27, 28, 864, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2023, 4, 27, 16, 15, 37, 136, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "O'Connell - Harvey Tasimacilik", "OConnell-HarveyTasimacilik.Bernhard90@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Littel, Murray and VonRueden Ulastirma", "LittelMurrayandVonRuedenUlastirma6@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Marquardt, Legros and Lockman Logistik", "MarquardtLegrosandLockmanLogistik.Huel@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Dickens LLC Tasimacilik", "DickensLLCTasimacilik_Carroll48@gmail.com" });
        }
    }
}
