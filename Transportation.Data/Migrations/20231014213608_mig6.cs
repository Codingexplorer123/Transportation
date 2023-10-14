using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c83d2d7-37a1-48fb-851f-e2fa592e4715", "75815823-7bde-42fa-9e3d-62e1f073c0e8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c83d2d7-37a1-48fb-851f-e2fa592e4715");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75815823-7bde-42fa-9e3d-62e1f073c0e8");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Nakliyeler",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 57 KP 123", "Cole", "O'Connell", "(513) 600-7563", 1, "(000) 365-4077" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 36 BE 160", "Favian", "Casper", "(535) 191-9177", 4, "(041) 890-7497" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 59 TS 397", "Rosalyn", "Schimmel", "(943) 412-2810", "(061) 784-7401" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 12 RH 771", "Marlene", "Ortiz", "(466) 729-0392", "(041) 089-5347" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d68aca3a-81e3-48f1-8974-530e04b6add2", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "96477b5b-c351-4587-99c5-4e97b4ab09e7", 0, "c6a09f80-f198-4f95-b0a3-adf1cbf5ed77", "admin@qwe.com", false, false, null, null, null, null, null, false, "50c8b1e4-d832-4c06-9b3c-92c39b5251b7", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2022, 1, 14, 17, 48, 0, 98, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2022, 1, 22, 2, 43, 4, 181, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2023, 3, 15, 8, 2, 12, 755, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2023, 1, 3, 22, 15, 31, 78, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Mayer LLC Tasimacilik", "MayerLLCTasimacilik.Stamm35@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Keebler, Marks and Champlin Ulastirma", "KeeblerMarksandChamplinUlastirma.Turner@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "DuBuque Inc Logistik", "DuBuqueIncLogistik12@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Simonis - Hirthe Logistik", "Simonis-HirtheLogistik89@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d68aca3a-81e3-48f1-8974-530e04b6add2", "96477b5b-c351-4587-99c5-4e97b4ab09e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d68aca3a-81e3-48f1-8974-530e04b6add2", "96477b5b-c351-4587-99c5-4e97b4ab09e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d68aca3a-81e3-48f1-8974-530e04b6add2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96477b5b-c351-4587-99c5-4e97b4ab09e7");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Nakliyeler",
                type: "int",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 8 NF 012", "Lindsey", "Bechtelar", "(391) 941-9772", 2, "(057) 023-2152" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 70 WU 859", "Jayde", "Towne", "(435) 262-7577", 1, "(074) 787-9669" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 57 IY 851", "Micheal", "Bashirian", "(091) 673-5645", "(094) 828-5718" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 34 RN 037", "Harmony", "Kulas", "(033) 188-8355", "(094) 369-9162" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c83d2d7-37a1-48fb-851f-e2fa592e4715", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "75815823-7bde-42fa-9e3d-62e1f073c0e8", 0, "8f7d06b0-ebbe-4945-b760-d4ffe8701a9c", "admin@qwe.com", false, false, null, null, null, null, null, false, "97b77271-3bb8-41cf-a981-e0a9dfaec97a", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2022, 6, 29, 23, 28, 25, 525, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2021, 4, 27, 2, 25, 13, 551, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2022, 4, 14, 17, 14, 37, 689, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2020, 12, 15, 18, 27, 1, 136, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Marks Inc Logistik", "MarksIncLogistik_Will29@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Moore - Pfannerstill Ulastirma", "Moore-PfannerstillUlastirma.Schiller@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Hoeger - Nienow Logistik", "Hoeger-NienowLogistik.OKon22@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Buckridge - Hyatt Ulastirma", "Buckridge-HyattUlastirma.Gerhold98@yahoo.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c83d2d7-37a1-48fb-851f-e2fa592e4715", "75815823-7bde-42fa-9e3d-62e1f073c0e8" });
        }
    }
}
