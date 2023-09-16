using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Transportation.Data.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TCNo = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "TR 46 DR 068", "Esta", "Lemke", "(611) 587-7749", 1, "(054) 655-1589", null, null },
                    { 2, "TR 61 SQ 602", "Francisca", "Cassin", "(029) 741-3462", 2, "(011) 733-3169", null, null },
                    { 3, "TR 64 HU 068", "Ocie", "Glover", "(205) 962-7343", 2, "(040) 048-7244", null, null },
                    { 4, "TR 51 BE 926", "Angelita", "Rolfson", "(735) 593-3785", 4, "(094) 569-4291", null, null }
                });

            migrationBuilder.InsertData(
                table: "Nakliyeler",
                columns: new[] { "NakliyeId", "Aciklama", "AracId", "MusteriDegerlendirmeleri", "NakliyeYapildimi", "TalepTarihi" },
                values: new object[,]
                {
                    { 1, null, null, null, true, new DateTime(2023, 1, 1, 0, 0, 43, 817, DateTimeKind.Local).AddTicks(9665) },
                    { 2, null, null, null, true, new DateTime(2023, 5, 17, 15, 1, 52, 921, DateTimeKind.Local).AddTicks(8708) },
                    { 3, null, null, null, false, new DateTime(2022, 8, 2, 12, 27, 28, 864, DateTimeKind.Local).AddTicks(5518) },
                    { 4, null, null, null, true, new DateTime(2023, 4, 27, 16, 15, 37, 136, DateTimeKind.Local).AddTicks(6951) }
                });

            migrationBuilder.InsertData(
                table: "Rezervasyonlar",
                columns: new[] { "RezervasyonId", "NakliyeFirmasiAdi", "NakliyeFirmasiEmail", "NakliyeId", "RezervasyonTarihi" },
                values: new object[,]
                {
                    { 1, "O'Connell - Harvey Tasimacilik", "OConnell-HarveyTasimacilik.Bernhard90@yahoo.com", null, null },
                    { 2, "Littel, Murray and VonRueden Ulastirma", "LittelMurrayandVonRuedenUlastirma6@yahoo.com", null, null },
                    { 3, "Marquardt, Legros and Lockman Logistik", "MarquardtLegrosandLockmanLogistik.Huel@gmail.com", null, null },
                    { 4, "Dickens LLC Tasimacilik", "DickensLLCTasimacilik_Carroll48@gmail.com", null, null }
                });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Rezervasyonlar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Nakliyeler");
        }
    }
}
