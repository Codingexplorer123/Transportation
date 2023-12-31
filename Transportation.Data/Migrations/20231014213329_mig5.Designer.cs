﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transportation.Data.Context;

#nullable disable

namespace Transportation.Data.Migrations
{
    [DbContext(typeof(TransportationDbContext))]
    [Migration("20231014213329_mig5")]
    partial class mig5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3c83d2d7-37a1-48fb-851f-e2fa592e4715",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "75815823-7bde-42fa-9e3d-62e1f073c0e8",
                            RoleId = "3c83d2d7-37a1-48fb-851f-e2fa592e4715"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TransportationEntity.Arac", b =>
                {
                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<string>("AracPlakaNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AracSoforuIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracSoforuSoyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracSoforuTelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AracTipi")
                        .HasColumnType("int");

                    b.Property<string>("FirmaTelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AracId");

                    b.HasIndex("AracPlakaNo")
                        .IsUnique();

                    b.HasIndex("AracSoforuTelNo")
                        .IsUnique();

                    b.ToTable("Araclar");

                    b.HasData(
                        new
                        {
                            AracId = 1,
                            AracPlakaNo = "TR 8 NF 012",
                            AracSoforuIsim = "Lindsey",
                            AracSoforuSoyisim = "Bechtelar",
                            AracSoforuTelNo = "(391) 941-9772",
                            AracTipi = 2,
                            FirmaTelNo = "(057) 023-2152"
                        },
                        new
                        {
                            AracId = 2,
                            AracPlakaNo = "TR 70 WU 859",
                            AracSoforuIsim = "Jayde",
                            AracSoforuSoyisim = "Towne",
                            AracSoforuTelNo = "(435) 262-7577",
                            AracTipi = 1,
                            FirmaTelNo = "(074) 787-9669"
                        },
                        new
                        {
                            AracId = 3,
                            AracPlakaNo = "TR 57 IY 851",
                            AracSoforuIsim = "Micheal",
                            AracSoforuSoyisim = "Bashirian",
                            AracSoforuTelNo = "(091) 673-5645",
                            AracTipi = 3,
                            FirmaTelNo = "(094) 828-5718"
                        },
                        new
                        {
                            AracId = 4,
                            AracPlakaNo = "TR 34 RN 037",
                            AracSoforuIsim = "Harmony",
                            AracSoforuSoyisim = "Kulas",
                            AracSoforuTelNo = "(033) 188-8355",
                            AracTipi = 4,
                            FirmaTelNo = "(094) 369-9162"
                        });
                });

            modelBuilder.Entity("TransportationEntity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Area")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Class")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Controller")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Icon")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MenuAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Menuler");
                });

            modelBuilder.Entity("TransportationEntity.MyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("TCNo")
                        .HasColumnType("bigint");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "75815823-7bde-42fa-9e3d-62e1f073c0e8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f7d06b0-ebbe-4945-b760-d4ffe8701a9c",
                            Email = "admin@qwe.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "97b77271-3bb8-41cf-a981-e0a9dfaec97a",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("TransportationEntity.Nakliye", b =>
                {
                    b.Property<int>("NakliyeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Aciklama")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("AracId")
                        .HasColumnType("int");

                    b.Property<string>("MusteriDegerlendirmeleri")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool?>("NakliyeYapildimi")
                        .HasColumnType("bit");

                    b.Property<int>("RezervasyonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("NakliyeId");

                    b.ToTable("Nakliyeler");

                    b.HasData(
                        new
                        {
                            NakliyeId = 1,
                            AracId = 1,
                            NakliyeYapildimi = true,
                            RezervasyonId = 1,
                            TalepTarihi = new DateTime(2022, 6, 29, 23, 28, 25, 525, DateTimeKind.Local).AddTicks(5651)
                        },
                        new
                        {
                            NakliyeId = 2,
                            AracId = 2,
                            NakliyeYapildimi = false,
                            RezervasyonId = 2,
                            TalepTarihi = new DateTime(2021, 4, 27, 2, 25, 13, 551, DateTimeKind.Local).AddTicks(7896)
                        },
                        new
                        {
                            NakliyeId = 3,
                            AracId = 3,
                            NakliyeYapildimi = true,
                            RezervasyonId = 3,
                            TalepTarihi = new DateTime(2022, 4, 14, 17, 14, 37, 689, DateTimeKind.Local).AddTicks(4594)
                        },
                        new
                        {
                            NakliyeId = 4,
                            AracId = 4,
                            NakliyeYapildimi = true,
                            RezervasyonId = 4,
                            TalepTarihi = new DateTime(2020, 12, 15, 18, 27, 1, 136, DateTimeKind.Local).AddTicks(5153)
                        });
                });

            modelBuilder.Entity("TransportationEntity.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervasyonId"));

                    b.Property<string>("NakliyeFirmasiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NakliyeFirmasiEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("RezervasyonTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("RezervasyonId");

                    b.HasIndex("NakliyeFirmasiEmail")
                        .IsUnique();

                    b.ToTable("Rezervasyonlar");

                    b.HasData(
                        new
                        {
                            RezervasyonId = 1,
                            NakliyeFirmasiAdi = "Marks Inc Logistik",
                            NakliyeFirmasiEmail = "MarksIncLogistik_Will29@gmail.com"
                        },
                        new
                        {
                            RezervasyonId = 2,
                            NakliyeFirmasiAdi = "Moore - Pfannerstill Ulastirma",
                            NakliyeFirmasiEmail = "Moore-PfannerstillUlastirma.Schiller@hotmail.com"
                        },
                        new
                        {
                            RezervasyonId = 3,
                            NakliyeFirmasiAdi = "Hoeger - Nienow Logistik",
                            NakliyeFirmasiEmail = "Hoeger-NienowLogistik.OKon22@yahoo.com"
                        },
                        new
                        {
                            RezervasyonId = 4,
                            NakliyeFirmasiAdi = "Buckridge - Hyatt Ulastirma",
                            NakliyeFirmasiEmail = "Buckridge-HyattUlastirma.Gerhold98@yahoo.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TransportationEntity.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TransportationEntity.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportationEntity.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TransportationEntity.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportationEntity.Arac", b =>
                {
                    b.HasOne("TransportationEntity.Nakliye", "Nakliye")
                        .WithMany("Araclar")
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nakliye");
                });

            modelBuilder.Entity("TransportationEntity.Menu", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TransportationEntity.Nakliye", b =>
                {
                    b.HasOne("TransportationEntity.Rezervasyon", "Rezervasyon")
                        .WithOne("Nakliye")
                        .HasForeignKey("TransportationEntity.Nakliye", "NakliyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rezervasyon");
                });

            modelBuilder.Entity("TransportationEntity.Nakliye", b =>
                {
                    b.Navigation("Araclar");
                });

            modelBuilder.Entity("TransportationEntity.Rezervasyon", b =>
                {
                    b.Navigation("Nakliye");
                });
#pragma warning restore 612, 618
        }
    }
}
