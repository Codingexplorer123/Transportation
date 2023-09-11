using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nakliyeler",
                columns: table => new
                {
                    NakliyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NakliyeYapildimi = table.Column<bool>(type: "bit", nullable: true),
                    MusteriDegerlendirmeleri = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TalepTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AracId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nakliyeler", x => x.NakliyeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCNo = table.Column<long>(type: "bigint", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyonlar",
                columns: table => new
                {
                    RezervasyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NakliyeId = table.Column<int>(type: "int", nullable: true),
                    RezervasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NakliyeFirmasiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NakliyeFirmasiEmail = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyonlar", x => x.RezervasyonId);
                    table.ForeignKey(
                        name: "FK_Rezervasyonlar_Nakliyeler_NakliyeId",
                        column: x => x.NakliyeId,
                        principalTable: "Nakliyeler",
                        principalColumn: "NakliyeId");
                });

            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    AracId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracTipi = table.Column<int>(type: "int", nullable: false),
                    AracSoforuIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracSoforuSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AracPlakaNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AracSoforuTelNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirmaTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezervasyonId = table.Column<int>(type: "int", nullable: true),
                    NakliyeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.AracId);
                    table.ForeignKey(
                        name: "FK_Araclar_Nakliyeler_NakliyeId",
                        column: x => x.NakliyeId,
                        principalTable: "Nakliyeler",
                        principalColumn: "NakliyeId");
                    table.ForeignKey(
                        name: "FK_Araclar_Rezervasyonlar_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyonlar",
                        principalColumn: "RezervasyonId");
                });

            migrationBuilder.InsertData(
                table: "Araclar",
                columns: new[] { "AracId", "AracPlakaNo", "AracSoforuIsim", "AracSoforuSoyisim", "AracSoforuTelNo", "AracTipi", "FirmaTelNo", "NakliyeId", "RezervasyonId" },
                values: new object[,]
                {
                    { 1, "TR 58 BM 071", "Fred", "Mann", "(188) 096-1349", 4, "(017) 414-0125", null, null },
                    { 2, "TR 36 FB 804", "Rusty", "Ferry", "(331) 807-0248", 2, "(048) 184-1161", null, null },
                    { 3, "TR 68 SJ 241", "Ayden", "Daniel", "(915) 050-8895", 2, "(056) 597-9453", null, null },
                    { 4, "TR 81 LW 432", "Lisandro", "Ebert", "(212) 158-7683", 2, "(001) 390-0269", null, null }
                });

            migrationBuilder.InsertData(
                table: "Nakliyeler",
                columns: new[] { "NakliyeId", "Aciklama", "AracId", "MusteriDegerlendirmeleri", "NakliyeYapildimi", "TalepTarihi" },
                values: new object[,]
                {
                    { 1, null, null, null, true, new DateTime(2021, 9, 8, 14, 43, 7, 819, DateTimeKind.Local).AddTicks(8817) },
                    { 2, null, null, null, true, new DateTime(2021, 3, 2, 1, 24, 33, 416, DateTimeKind.Local).AddTicks(6722) },
                    { 3, null, null, null, true, new DateTime(2023, 1, 7, 3, 43, 57, 709, DateTimeKind.Local).AddTicks(3517) },
                    { 4, null, null, null, true, new DateTime(2022, 12, 16, 3, 16, 29, 450, DateTimeKind.Local).AddTicks(7533) }
                });

            migrationBuilder.InsertData(
                table: "Rezervasyonlar",
                columns: new[] { "RezervasyonId", "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[,]
                {
                    { 1, "Herzog and Sons Ulastirma", "HerzogandSonsUlastirma.Corwin@hotmail.com", null, null },
                    { 2, "Marvin and Sons Nakliyat", "MarvinandSonsNakliyat_Lang39@gmail.com", null, null },
                    { 3, "Wuckert - Klocko Tasimacilik", "Wuckert-KlockoTasimacilik70@gmail.com", null, null },
                    { 4, "Gaylord Group Logistik", "GaylordGroupLogistik_Blick64@hotmail.com", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Adress", "DogumTarihi", "Email", "LastName", "Name", "Password", "PhoneNumber", "TCNo" },
                values: new object[] { 1, "Istanbul", new DateTime(1955, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "berk@gmail.com", "Ozgurcan", "Berk", "1234", "5351111111", 11111111111L });

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_AracPlakaNo",
                table: "Araclar",
                column: "AracPlakaNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_AracSoforuTelNo",
                table: "Araclar",
                column: "AracSoforuTelNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_NakliyeId",
                table: "Araclar",
                column: "NakliyeId");

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_RezervasyonId",
                table: "Araclar",
                column: "RezervasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyonlar_NakliyeFirmasiEmail",
                table: "Rezervasyonlar",
                column: "NakliyeFirmasiEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyonlar_NakliyeId",
                table: "Rezervasyonlar",
                column: "NakliyeId",
                unique: true,
                filter: "[NakliyeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhoneNumber",
                table: "Users",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Rezervasyonlar");

            migrationBuilder.DropTable(
                name: "Nakliyeler");
        }
    }
}
