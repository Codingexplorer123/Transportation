using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_NakliyeId",
                table: "Rezervasyonlar");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyonlar_NakliyeId",
                table: "Rezervasyonlar");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f55271d7-6c57-49ee-988b-e102d85bcbb0", "9286a6b4-1075-4a0a-ab0d-e66dc3a73011" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f55271d7-6c57-49ee-988b-e102d85bcbb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9286a6b4-1075-4a0a-ab0d-e66dc3a73011");

            migrationBuilder.DropColumn(
                name: "NakliyeId",
                table: "Rezervasyonlar");

            migrationBuilder.AlterColumn<int>(
                name: "RezervasyonId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RezervasyonId",
                table: "Nakliyeler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 52 GW 318", "Moriah", "Smith", "(062) 796-0797", 3, "(000) 496-3867" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 57 WB 255", "Chloe", "Runolfsdottir", "(986) 935-9934", 2, "(004) 969-0252" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 80 ZL 461", "Jarret", "Douglas", "(776) 206-0543", 1, "(041) 370-1539" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 80 UQ 553", "Chris", "Koss", "(629) 232-2480", "(072) 109-4830" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8fe2625-90fd-4baa-a50e-5452236ea50d", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83f7f9a8-304d-4e89-837f-8d4e82ffd365", 0, "af20862f-d418-443b-aae2-065e98cad561", "admin@qwe.com", false, false, null, null, null, null, null, false, "2b3763c1-9942-4875-812e-bc8976e44e87", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { 1, new DateTime(2022, 5, 6, 8, 34, 2, 689, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { 2, new DateTime(2021, 9, 27, 21, 21, 50, 10, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { 3, new DateTime(2023, 9, 13, 1, 29, 20, 635, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                columns: new[] { "NakliyeYapildimi", "RezervasyonId", "TalepTarihi" },
                values: new object[] { true, 4, new DateTime(2021, 11, 9, 4, 23, 7, 281, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Borer and Sons Nakliyat", "BorerandSonsNakliyat_Spinka@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Green - Hudson Tasimacilik", "Green-HudsonTasimacilik79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Cummings - Yost Logistik", "Cummings-YostLogistik31@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Hessel, Conn and Kerluke Logistik", "HesselConnandKerlukeLogistik10@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8fe2625-90fd-4baa-a50e-5452236ea50d", "83f7f9a8-304d-4e89-837f-8d4e82ffd365" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_RezervasyonId",
                table: "Rezervasyonlar",
                column: "RezervasyonId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_RezervasyonId",
                table: "Rezervasyonlar");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8fe2625-90fd-4baa-a50e-5452236ea50d", "83f7f9a8-304d-4e89-837f-8d4e82ffd365" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8fe2625-90fd-4baa-a50e-5452236ea50d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83f7f9a8-304d-4e89-837f-8d4e82ffd365");

            migrationBuilder.DropColumn(
                name: "RezervasyonId",
                table: "Nakliyeler");

            migrationBuilder.AlterColumn<int>(
                name: "RezervasyonId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NakliyeId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 49 XF 972", "Parker", "Price", "(528) 910-3986", 4, "(037) 972-1893" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 26 VO 455", "Nathanial", "Lakin", "(048) 465-9375", 1, "(051) 737-6310" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 64 JL 659", "Kristy", "Ruecker", "(216) 896-0262", 2, "(077) 804-1901" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 42 WN 725", "Adonis", "Rempel", "(272) 374-7145", "(077) 385-4991" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f55271d7-6c57-49ee-988b-e102d85bcbb0", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9286a6b4-1075-4a0a-ab0d-e66dc3a73011", 0, "0be8f71f-4808-497f-9857-a7574214b9c9", "admin@qwe.com", false, false, null, null, null, null, null, false, "d25740ec-f1f1-4b79-b13a-e859281c7454", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2023, 5, 4, 15, 47, 9, 0, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2020, 11, 9, 8, 55, 53, 591, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2023, 8, 25, 16, 33, 25, 808, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2020, 12, 28, 5, 13, 36, 370, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Howell, Volkman and McKenzie Ulastirma", "HowellVolkmanandMcKenzieUlastirma_Streich@hotmail.com", 1 });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Kassulke, Halvorson and Kuhlman Tasimacilik", "KassulkeHalvorsonandKuhlmanTasimacilik11@yahoo.com", 2 });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Schaefer Inc Logistik", "SchaeferIncLogistik_Gibson@gmail.com", 3 });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Hoppe - Goyette Nakliyat", "Hoppe-GoyetteNakliyat.Sawayn@hotmail.com", 4 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f55271d7-6c57-49ee-988b-e102d85bcbb0", "9286a6b4-1075-4a0a-ab0d-e66dc3a73011" });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyonlar_NakliyeId",
                table: "Rezervasyonlar",
                column: "NakliyeId",
                unique: true,
                filter: "[NakliyeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_NakliyeId",
                table: "Rezervasyonlar",
                column: "NakliyeId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId");
        }
    }
}
