using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_RezervasyonId",
                table: "Rezervasyonlar");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26be009e-0de4-4d1a-9b0e-218a454ad1d8", "697775a6-2189-46c0-badf-cff360ad2e70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26be009e-0de4-4d1a-9b0e-218a454ad1d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "697775a6-2189-46c0-badf-cff360ad2e70");

            migrationBuilder.AlterColumn<int>(
                name: "RezervasyonId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Nakliyeler",
                type: "int",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 2 LT 340", "Aubree", "Ryan", "(131) 167-4419", 3, "(092) 202-2179" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 79 SY 983", "Geovany", "Howe", "(733) 081-2461", "(028) 167-6342" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 31 RS 570", "Bud", "Berge", "(353) 586-3495", 3, "(046) 219-8099" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 4 BL 387", "Luisa", "Hane", "(046) 659-6247", 3, "(054) 847-5510" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91f93204-82f1-42c7-ae22-e6fd4d1e25de", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "71634a5b-b671-4003-b233-670ceae8cca9", 0, "28e4878b-8a8b-486d-8dd7-9286821845ed", "admin@qwe.com", false, false, null, null, null, null, null, false, "f8818cc0-956d-4cfb-9d20-f983adceca9c", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2021, 5, 22, 0, 30, 46, 458, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2023, 9, 24, 19, 16, 2, 57, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2021, 6, 26, 13, 40, 4, 616, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2020, 10, 22, 14, 54, 26, 127, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Treutel, Purdy and Glover Nakliyat", "TreutelPurdyandGloverNakliyat39@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Kuhic, Beer and Skiles Ulastirma", "KuhicBeerandSkilesUlastirma_Legros@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Lowe, Beer and Casper Ulastirma", "LoweBeerandCasperUlastirma_Marvin80@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "O'Conner - Rohan Ulastirma", "OConner-RohanUlastirma51@yahoo.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91f93204-82f1-42c7-ae22-e6fd4d1e25de", "71634a5b-b671-4003-b233-670ceae8cca9" });

            migrationBuilder.AddForeignKey(
                name: "FK_Nakliyeler_Rezervasyonlar_NakliyeId",
                table: "Nakliyeler",
                column: "NakliyeId",
                principalTable: "Rezervasyonlar",
                principalColumn: "RezervasyonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nakliyeler_Rezervasyonlar_NakliyeId",
                table: "Nakliyeler");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91f93204-82f1-42c7-ae22-e6fd4d1e25de", "71634a5b-b671-4003-b233-670ceae8cca9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91f93204-82f1-42c7-ae22-e6fd4d1e25de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71634a5b-b671-4003-b233-670ceae8cca9");

            migrationBuilder.AlterColumn<int>(
                name: "RezervasyonId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Nakliyeler",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEWID()")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 35 BZ 299", "Althea", "Powlowski", "(984) 099-7185", 2, "(062) 069-9290" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 40 QY 623", "Lyla", "Nienow", "(595) 996-8719", "(036) 611-6806" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 8 JG 665", "Dashawn", "Hahn", "(812) 628-0997", 1, "(069) 107-4966" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 8 GB 921", "Adrianna", "Emard", "(155) 567-2203", 1, "(070) 713-8009" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26be009e-0de4-4d1a-9b0e-218a454ad1d8", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "697775a6-2189-46c0-badf-cff360ad2e70", 0, "b7645107-0a71-40f8-9ed4-d842457bac48", "admin@qwe.com", false, false, null, null, null, null, null, false, "2957a259-916e-447b-a9e3-16a0146d13a7", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2021, 10, 28, 9, 21, 17, 58, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2020, 12, 30, 12, 16, 49, 784, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2022, 5, 30, 3, 19, 47, 873, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2021, 2, 1, 4, 54, 50, 133, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Murray Inc Logistik", "MurrayIncLogistik.Schuppe20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Ward Inc Tasimacilik", "WardIncTasimacilik.Ziemann@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Considine Inc Logistik", "ConsidineIncLogistik_Gusikowski@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Frami, Aufderhar and Flatley Ulastirma", "FramiAufderharandFlatleyUlastirma68@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "26be009e-0de4-4d1a-9b0e-218a454ad1d8", "697775a6-2189-46c0-badf-cff360ad2e70" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_RezervasyonId",
                table: "Rezervasyonlar",
                column: "RezervasyonId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
