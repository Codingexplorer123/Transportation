using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
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
                keyValues: new object[] { "bc3f9389-782a-44db-a8c8-31ea50f8978b", "a19464fb-ab6e-4a02-989e-d1bc580a720c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc3f9389-782a-44db-a8c8-31ea50f8978b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a19464fb-ab6e-4a02-989e-d1bc580a720c");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 57 JZ 157", "Ashley", "Reichel", "(708) 910-1996", "(078) 756-4798" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 77 YG 699", "Edyth", "Champlin", "(353) 739-1601", "(020) 375-9762" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 69 LU 327", "Felipe", "Heaney", "(129) 477-5529", 2, "(044) 641-3990" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 32 AP 050", "Freeda", "McGlynn", "(768) 282-8057", 1, "(042) 585-0383" });

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
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Nitzsche, Pollich and Powlowski Logistik", "NitzschePollichandPowlowskiLogistik.Stracke@gmail.com", null, null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Lockman - Dibbert Tasimacilik", "Lockman-DibbertTasimacilik.Pagac@gmail.com", null, null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "O'Reilly, Huels and Yost Nakliyat", "OReillyHuelsandYostNakliyat.Collier@yahoo.com", null, null });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Borer Inc Logistik", "BorerIncLogistik_Larson@hotmail.com", null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc", "8ebedf09-5a0c-4210-92a1-a0f52d6fe781" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc", "8ebedf09-5a0c-4210-92a1-a0f52d6fe781" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9d96bbf-a057-4bd1-8a09-2acd3f4d1dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ebedf09-5a0c-4210-92a1-a0f52d6fe781");

            migrationBuilder.AlterColumn<int>(
                name: "NakliyeId",
                table: "Rezervasyonlar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 10 LG 577", "Laurine", "Terry", "(552) 307-8977", "(059) 981-8846" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 25 IW 631", "Elenora", "Hettinger", "(611) 904-6911", "(082) 495-4644" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 28 MH 902", "Nelda", "Spinka", "(093) 977-3504", 1, "(043) 867-8025" });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo" },
                values: new object[] { "TR 17 XP 417", "Thad", "Ziemann", "(606) 132-9799", 4, "(009) 649-8723" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc3f9389-782a-44db-a8c8-31ea50f8978b", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a19464fb-ab6e-4a02-989e-d1bc580a720c", 0, "0021f883-2bc8-48a6-85b5-1e4b68be01a9", "admin@qwe.com", false, false, null, null, null, null, null, false, "cf864841-4ecf-429d-b140-2cdfa16d1e76", null, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2022, 4, 9, 8, 41, 29, 943, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2022, 12, 26, 18, 46, 37, 852, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                column: "TalepTarihi",
                value: new DateTime(2022, 2, 2, 15, 15, 27, 984, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2021, 1, 7, 7, 54, 48, 699, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "O'Reilly, Mann and Stamm Logistik", "OReillyMannandStammLogistik14@hotmail.com", 0, new DateTime(2022, 10, 10, 4, 9, 6, 645, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Smitham, Carroll and Lowe Nakliyat", "SmithamCarrollandLoweNakliyat.Reinger@yahoo.com", 0, new DateTime(2021, 2, 23, 12, 36, 59, 92, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Halvorson and Sons Logistik", "HalvorsonandSonsLogistik32@hotmail.com", 0, new DateTime(2022, 5, 25, 17, 16, 9, 671, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[] { "Kiehn, Hills and Bechtelar Nakliyat", "KiehnHillsandBechtelarNakliyat.Erdman79@yahoo.com", 0, new DateTime(2022, 6, 29, 17, 27, 48, 53, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc3f9389-782a-44db-a8c8-31ea50f8978b", "a19464fb-ab6e-4a02-989e-d1bc580a720c" });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyonlar_NakliyeId",
                table: "Rezervasyonlar",
                column: "NakliyeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyonlar_Nakliyeler_NakliyeId",
                table: "Rezervasyonlar",
                column: "NakliyeId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
