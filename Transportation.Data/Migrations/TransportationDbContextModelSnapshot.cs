﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transportation.Data.Context;

#nullable disable

namespace Transportation.Data.Migrations
{
    [DbContext(typeof(TransportationDbContext))]
    partial class TransportationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "26be009e-0de4-4d1a-9b0e-218a454ad1d8",
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
                            UserId = "697775a6-2189-46c0-badf-cff360ad2e70",
                            RoleId = "26be009e-0de4-4d1a-9b0e-218a454ad1d8"
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
                            AracPlakaNo = "TR 35 BZ 299",
                            AracSoforuIsim = "Althea",
                            AracSoforuSoyisim = "Powlowski",
                            AracSoforuTelNo = "(984) 099-7185",
                            AracTipi = 2,
                            FirmaTelNo = "(062) 069-9290"
                        },
                        new
                        {
                            AracId = 2,
                            AracPlakaNo = "TR 40 QY 623",
                            AracSoforuIsim = "Lyla",
                            AracSoforuSoyisim = "Nienow",
                            AracSoforuTelNo = "(595) 996-8719",
                            AracTipi = 2,
                            FirmaTelNo = "(036) 611-6806"
                        },
                        new
                        {
                            AracId = 3,
                            AracPlakaNo = "TR 8 JG 665",
                            AracSoforuIsim = "Dashawn",
                            AracSoforuSoyisim = "Hahn",
                            AracSoforuTelNo = "(812) 628-0997",
                            AracTipi = 1,
                            FirmaTelNo = "(069) 107-4966"
                        },
                        new
                        {
                            AracId = 4,
                            AracPlakaNo = "TR 8 GB 921",
                            AracSoforuIsim = "Adrianna",
                            AracSoforuSoyisim = "Emard",
                            AracSoforuTelNo = "(155) 567-2203",
                            AracTipi = 1,
                            FirmaTelNo = "(070) 713-8009"
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
                            Id = "697775a6-2189-46c0-badf-cff360ad2e70",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b7645107-0a71-40f8-9ed4-d842457bac48",
                            Email = "admin@qwe.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2957a259-916e-447b-a9e3-16a0146d13a7",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("TransportationEntity.Nakliye", b =>
                {
                    b.Property<int>("NakliyeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NakliyeId"));

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
                            TalepTarihi = new DateTime(2021, 10, 28, 9, 21, 17, 58, DateTimeKind.Local).AddTicks(3359)
                        },
                        new
                        {
                            NakliyeId = 2,
                            AracId = 2,
                            NakliyeYapildimi = true,
                            RezervasyonId = 2,
                            TalepTarihi = new DateTime(2020, 12, 30, 12, 16, 49, 784, DateTimeKind.Local).AddTicks(3935)
                        },
                        new
                        {
                            NakliyeId = 3,
                            AracId = 3,
                            NakliyeYapildimi = true,
                            RezervasyonId = 3,
                            TalepTarihi = new DateTime(2022, 5, 30, 3, 19, 47, 873, DateTimeKind.Local).AddTicks(7930)
                        },
                        new
                        {
                            NakliyeId = 4,
                            AracId = 4,
                            NakliyeYapildimi = true,
                            RezervasyonId = 4,
                            TalepTarihi = new DateTime(2021, 2, 1, 4, 54, 50, 133, DateTimeKind.Local).AddTicks(9653)
                        });
                });

            modelBuilder.Entity("TransportationEntity.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonId")
                        .HasColumnType("int");

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
                            NakliyeFirmasiAdi = "Murray Inc Logistik",
                            NakliyeFirmasiEmail = "MurrayIncLogistik.Schuppe20@yahoo.com"
                        },
                        new
                        {
                            RezervasyonId = 2,
                            NakliyeFirmasiAdi = "Ward Inc Tasimacilik",
                            NakliyeFirmasiEmail = "WardIncTasimacilik.Ziemann@hotmail.com"
                        },
                        new
                        {
                            RezervasyonId = 3,
                            NakliyeFirmasiAdi = "Considine Inc Logistik",
                            NakliyeFirmasiEmail = "ConsidineIncLogistik_Gusikowski@hotmail.com"
                        },
                        new
                        {
                            RezervasyonId = 4,
                            NakliyeFirmasiAdi = "Frami, Aufderhar and Flatley Ulastirma",
                            NakliyeFirmasiEmail = "FramiAufderharandFlatleyUlastirma68@gmail.com"
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

            modelBuilder.Entity("TransportationEntity.Rezervasyon", b =>
                {
                    b.HasOne("TransportationEntity.Nakliye", "Nakliye")
                        .WithOne("Rezervasyon")
                        .HasForeignKey("TransportationEntity.Rezervasyon", "RezervasyonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nakliye");
                });

            modelBuilder.Entity("TransportationEntity.Nakliye", b =>
                {
                    b.Navigation("Araclar");

                    b.Navigation("Rezervasyon");
                });
#pragma warning restore 612, 618
        }
    }
}
