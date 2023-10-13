using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc", "8ebedf09-5a0c-4210-92a1-a0f52d6fe781" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ebedf09-5a0c-4210-92a1-a0f52d6fe781");

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
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 64 JL 659", "Kristy", "Ruecker", "(216) 896-0262", "(077) 804-1901" });

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
                column: "TalepTarihi",
                value: new DateTime(2020, 12, 28, 5, 13, 36, 370, DateTimeKind.Local).AddTicks(4109));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 57 JZ 157", "Ashley", "Reichel", "(708) 910-1996", 1, "(078) 756-4798" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 77 YG 699", "Edyth", "Champlin", "(353) 739-1601", 2, "(020) 375-9762" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 69 LU 327", "Felipe", "Heaney", "(129) 477-5529", "(044) 641-3990" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 32 AP 050", "Freeda", "McGlynn", "(768) 282-8057", "(042) 585-0383" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ebedf09-5a0c-4210-92a1-a0f52d6fe781", 0, "f17da513-1c81-4dcd-aedc-cabbeca852ff", "admin@qwe.com", false, false, null, null, null, null, null, false, "cd962654-fc94-424f-b20c-e9895a20bdeb", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2023, 3, 14, 14, 39, 24, 69, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2022, 7, 14, 12, 24, 3, 469, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2023, 6, 17, 10, 13, 13, 507, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2022, 8, 16, 8, 21, 27, 883, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Nitzsche, Pollich and Powlowski Logistik", "NitzschePollichandPowlowskiLogistik.Stracke@gmail.com", null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Lockman - Dibbert Tasimacilik", "Lockman-DibbertTasimacilik.Pagac@gmail.com", null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "O'Reilly, Huels and Yost Nakliyat", "OReillyHuelsandYostNakliyat.Collier@yahoo.com", null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId" },
                values: new object[] { "Borer Inc Logistik", "BorerIncLogistik_Larson@hotmail.com", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc", "8ebedf09-5a0c-4210-92a1-a0f52d6fe781" });
        }
    }
}
