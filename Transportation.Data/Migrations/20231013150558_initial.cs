using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_Nakliyeler_NakliyeId",
                table: "Araclar");

            migrationBuilder.DropIndex(
                name: "IX_Araclar_NakliyeId",
                table: "Araclar");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1dabf83-9801-425a-86aa-fdb10dbc62c4", "c881d303-8d8a-411b-a683-d25a1deeecef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1dabf83-9801-425a-86aa-fdb10dbc62c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c881d303-8d8a-411b-a683-d25a1deeecef");

            migrationBuilder.DropColumn(
                name: "NakliyeId",
                table: "Araclar");

            migrationBuilder.AddColumn<int>(
                name: "RezervasyonId",
                table: "Nakliyeler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TCNo",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "AracId",
                table: "Araclar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo" },
                values: new object[] { "TR 17 KJ 093", "Sylvester", "Steuber", "(509) 068-2626", "(089) 464-8518" });

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
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { null, new DateTime(2023, 6, 18, 16, 16, 42, 585, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { null, new DateTime(2021, 12, 16, 22, 19, 59, 444, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "RezervasyonId", "TalepTarihi" },
                values: new object[] { true, null, new DateTime(2021, 1, 17, 2, 10, 17, 51, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                columns: new[] { "RezervasyonId", "TalepTarihi" },
                values: new object[] { null, new DateTime(2022, 10, 23, 9, 53, 30, 221, DateTimeKind.Local).AddTicks(606) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_Nakliyeler_AracId",
                table: "Araclar",
                column: "AracId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_Nakliyeler_AracId",
                table: "Araclar");

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

            migrationBuilder.DropColumn(
                name: "RezervasyonId",
                table: "Nakliyeler");

            migrationBuilder.AlterColumn<long>(
                name: "TCNo",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AracId",
                table: "Araclar",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NakliyeId",
                table: "Araclar",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 1,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo", "NakliyeId" },
                values: new object[] { "TR 43 QZ 914", "Elsa", "Ullrich", "(549) 835-0454", "(079) 042-3094", null });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 2,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo", "NakliyeId" },
                values: new object[] { "TR 30 XX 355", "Winfield", "Smitham", "(853) 507-0534", 4, "(045) 566-7404", null });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 3,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo", "NakliyeId" },
                values: new object[] { "TR 59 FK 544", "Jordan", "Kohler", "(843) 405-2847", 4, "(091) 069-9610", null });

            migrationBuilder.UpdateData(
                table: "Araclar",
                keyColumn: "AracId",
                keyValue: 4,
                columns: new[] { "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "FirmaTelNo", "NakliyeId" },
                values: new object[] { "TR 25 XO 792", "Trevion", "Gutkowski", "(715) 710-9852", "(020) 258-9003", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1dabf83-9801-425a-86aa-fdb10dbc62c4", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TCNo", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c881d303-8d8a-411b-a683-d25a1deeecef", 0, "80791bdc-f9a4-4962-bb2b-c836576fef29", "admin@qwe.com", false, false, null, null, null, null, null, false, "b9939e5f-b18e-4c5a-811a-83f206361d7a", 0L, false, "admin" });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 1,
                column: "TalepTarihi",
                value: new DateTime(2021, 12, 24, 6, 46, 40, 784, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 2,
                column: "TalepTarihi",
                value: new DateTime(2021, 11, 7, 15, 56, 49, 117, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 3,
                columns: new[] { "NakliyeYapildimi", "TalepTarihi" },
                values: new object[] { false, new DateTime(2021, 5, 19, 13, 3, 18, 641, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Nakliyeler",
                keyColumn: "NakliyeId",
                keyValue: 4,
                column: "TalepTarihi",
                value: new DateTime(2020, 10, 23, 20, 53, 37, 885, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 1,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Schoen - Langosh Tasimacilik", "Schoen-LangoshTasimacilik.Streich83@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 2,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Kerluke, Kuvalis and Smith Logistik", "KerlukeKuvalisandSmithLogistik_Waters59@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 3,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Hammes Inc Ulastirma", "HammesIncUlastirma.Stanton66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Rezervasyonlar",
                keyColumn: "RezervasyonId",
                keyValue: 4,
                columns: new[] { "NakliyeFirmasiAdi", "NakliyeFirmasiEmail" },
                values: new object[] { "Corwin - Dicki Nakliyat", "Corwin-DickiNakliyat43@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1dabf83-9801-425a-86aa-fdb10dbc62c4", "c881d303-8d8a-411b-a683-d25a1deeecef" });

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_NakliyeId",
                table: "Araclar",
                column: "NakliyeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_Nakliyeler_NakliyeId",
                table: "Araclar",
                column: "NakliyeId",
                principalTable: "Nakliyeler",
                principalColumn: "NakliyeId");
        }
    }
}
