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
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8807ad9-3dfd-4344-b78e-5e3332263664", "63da0060-7eb2-4c20-8cff-6c5fc1c78419" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8807ad9-3dfd-4344-b78e-5e3332263664");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63da0060-7eb2-4c20-8cff-6c5fc1c78419");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 58 QR 079", "Kade", "Abernathy", "(827) 600-9779", "(070) 338-7775" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 58 MZ 091", "Dorcas", "Kihn", "(972) 437-8419", 3, "(045) 986-4873" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 11 VJ 582", "Terence", "Kuphal", "(876) 231-4664", 4, "(034) 392-1238" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 26 JY 859", "Selena", "O'Connell", "(088) 930-4996", 4, "(050) 287-4773" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08b545db-3a01-4fad-adde-4ab24e793ec9", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0ed63683-f942-453c-beeb-7fabb2679d42", 0, "5acddeae-4e7e-45dd-8b27-9e6f7e050bd5", "admin@qwe.com", false, false, null, null, null, null, null, false, "3a4d03f7-0c23-47de-958f-0bbba5375c58", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2021, 5, 18, 11, 27, 38, 107, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2021, 12, 30, 18, 48, 48, 573, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2023, 4, 30, 10, 30, 41, 245, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2022, 9, 13, 23, 15, 35, 789, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Kohler Group Tasimacilik", "KohlerGroupTasimacilik_Friesen88@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Metz, Parisian and Schiller Tasimacilik", "MetzParisianandSchillerTasimacilik.Wilkinson@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Krajcik, Lindgren and Renner Tasimacilik", "KrajcikLindgrenandRennerTasimacilik.Boehm@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "McClure, Will and Borer Nakliyat", "McClureWillandBorerNakliyat_Bahringer2@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "08b545db-3a01-4fad-adde-4ab24e793ec9", "0ed63683-f942-453c-beeb-7fabb2679d42" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08b545db-3a01-4fad-adde-4ab24e793ec9", "0ed63683-f942-453c-beeb-7fabb2679d42" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08b545db-3a01-4fad-adde-4ab24e793ec9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ed63683-f942-453c-beeb-7fabb2679d42");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 15 OW 919", "Keith", "Pollich", "(854) 596-3914", "(040) 927-4931" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 27 GF 487", "Jenifer", "Hodkiewicz", "(660) 854-9387", 1, "(092) 383-8392" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 77 HM 326", "Lula", "O'Connell", "(083) 470-5741", 1, "(058) 501-7746" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 17 KJ 093", "Sylvester", "Steuber", "(509) 068-2626", 1, "(089) 464-8518" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8807ad9-3dfd-4344-b78e-5e3332263664", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "63da0060-7eb2-4c20-8cff-6c5fc1c78419", 0, "62a4c7a8-4fce-4b56-a020-bffa51177c20", "admin@qwe.com", false, false, null, null, null, null, null, false, "51a0e03e-ea23-433c-ab4b-09dd6e22f303", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2023, 6, 18, 16, 16, 42, 585, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { true, new DateTime(2021, 12, 16, 22, 19, 59, 444, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2021, 1, 17, 2, 10, 17, 51, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2022, 10, 23, 9, 53, 30, 221, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Mertz Inc Nakliyat", "MertzIncNakliyat.Wilderman@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Sawayn, Cummerata and Russel Nakliyat", "SawaynCummerataandRusselNakliyat.Ratke29@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Ward - Schmitt Nakliyat", "Ward-SchmittNakliyat_Parisian@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Bauch, Kemmer and Mann Ulastirma", "BauchKemmerandMannUlastirma21@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8807ad9-3dfd-4344-b78e-5e3332263664", "63da0060-7eb2-4c20-8cff-6c5fc1c78419" });
        }
    }
}
