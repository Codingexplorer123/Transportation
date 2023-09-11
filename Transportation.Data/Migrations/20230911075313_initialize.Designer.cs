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
    [Migration("20230911075313_initialize")]
    partial class initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransportationEntity.Arac", b =>
                {
                    b.Property<int>("AracId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AracId"));

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

                    b.Property<int?>("NakliyeId")
                        .HasColumnType("int");

                    b.Property<int?>("RezervasyonId")
                        .HasColumnType("int");

                    b.HasKey("AracId");

                    b.HasIndex("AracPlakaNo")
                        .IsUnique();

                    b.HasIndex("AracSoforuTelNo")
                        .IsUnique();

                    b.HasIndex("NakliyeId");

                    b.HasIndex("RezervasyonId");

                    b.ToTable("Araclar");

                    b.HasData(
                        new
                        {
                            AracId = 1,
                            AracPlakaNo = "TR 58 BM 071",
                            AracSoforuIsim = "Fred",
                            AracSoforuSoyisim = "Mann",
                            AracSoforuTelNo = "(188) 096-1349",
                            AracTipi = 4,
                            FirmaTelNo = "(017) 414-0125"
                        },
                        new
                        {
                            AracId = 2,
                            AracPlakaNo = "TR 36 FB 804",
                            AracSoforuIsim = "Rusty",
                            AracSoforuSoyisim = "Ferry",
                            AracSoforuTelNo = "(331) 807-0248",
                            AracTipi = 2,
                            FirmaTelNo = "(048) 184-1161"
                        },
                        new
                        {
                            AracId = 3,
                            AracPlakaNo = "TR 68 SJ 241",
                            AracSoforuIsim = "Ayden",
                            AracSoforuSoyisim = "Daniel",
                            AracSoforuTelNo = "(915) 050-8895",
                            AracTipi = 2,
                            FirmaTelNo = "(056) 597-9453"
                        },
                        new
                        {
                            AracId = 4,
                            AracPlakaNo = "TR 81 LW 432",
                            AracSoforuIsim = "Lisandro",
                            AracSoforuSoyisim = "Ebert",
                            AracSoforuTelNo = "(212) 158-7683",
                            AracTipi = 2,
                            FirmaTelNo = "(001) 390-0269"
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

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("NakliyeId");

                    b.ToTable("Nakliyeler");

                    b.HasData(
                        new
                        {
                            NakliyeId = 1,
                            NakliyeYapildimi = true,
                            TalepTarihi = new DateTime(2021, 9, 8, 14, 43, 7, 819, DateTimeKind.Local).AddTicks(8817)
                        },
                        new
                        {
                            NakliyeId = 2,
                            NakliyeYapildimi = true,
                            TalepTarihi = new DateTime(2021, 3, 2, 1, 24, 33, 416, DateTimeKind.Local).AddTicks(6722)
                        },
                        new
                        {
                            NakliyeId = 3,
                            NakliyeYapildimi = true,
                            TalepTarihi = new DateTime(2023, 1, 7, 3, 43, 57, 709, DateTimeKind.Local).AddTicks(3517)
                        },
                        new
                        {
                            NakliyeId = 4,
                            NakliyeYapildimi = true,
                            TalepTarihi = new DateTime(2022, 12, 16, 3, 16, 29, 450, DateTimeKind.Local).AddTicks(7533)
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

                    b.Property<int?>("NakliyeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RezervasyonTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("RezervasyonId");

                    b.HasIndex("NakliyeFirmasiEmail")
                        .IsUnique();

                    b.HasIndex("NakliyeId")
                        .IsUnique()
                        .HasFilter("[NakliyeId] IS NOT NULL");

                    b.ToTable("Rezervasyonlar");

                    b.HasData(
                        new
                        {
                            RezervasyonId = 1,
                            NakliyeFirmasiAdi = "Herzog and Sons Ulastirma",
                            NakliyeFirmasiEmail = "HerzogandSonsUlastirma.Corwin@hotmail.com"
                        },
                        new
                        {
                            RezervasyonId = 2,
                            NakliyeFirmasiAdi = "Marvin and Sons Nakliyat",
                            NakliyeFirmasiEmail = "MarvinandSonsNakliyat_Lang39@gmail.com"
                        },
                        new
                        {
                            RezervasyonId = 3,
                            NakliyeFirmasiAdi = "Wuckert - Klocko Tasimacilik",
                            NakliyeFirmasiEmail = "Wuckert-KlockoTasimacilik70@gmail.com"
                        },
                        new
                        {
                            RezervasyonId = 4,
                            NakliyeFirmasiAdi = "Gaylord Group Logistik",
                            NakliyeFirmasiEmail = "GaylordGroupLogistik_Blick64@hotmail.com"
                        });
                });

            modelBuilder.Entity("TransportationEntity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("TCNo")
                        .HasMaxLength(11)
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Adress = "Istanbul",
                            DogumTarihi = new DateTime(1955, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "berk@gmail.com",
                            LastName = "Ozgurcan",
                            Name = "Berk",
                            Password = "1234",
                            PhoneNumber = "5351111111",
                            TCNo = 11111111111L
                        });
                });

            modelBuilder.Entity("TransportationEntity.Arac", b =>
                {
                    b.HasOne("TransportationEntity.Nakliye", "Nakliye")
                        .WithMany("Araclar")
                        .HasForeignKey("NakliyeId");

                    b.HasOne("TransportationEntity.Rezervasyon", "Rezervasyon")
                        .WithMany()
                        .HasForeignKey("RezervasyonId");

                    b.Navigation("Nakliye");

                    b.Navigation("Rezervasyon");
                });

            modelBuilder.Entity("TransportationEntity.Rezervasyon", b =>
                {
                    b.HasOne("TransportationEntity.Nakliye", "Nakliye")
                        .WithOne("Rezervasyon")
                        .HasForeignKey("TransportationEntity.Rezervasyon", "NakliyeId");

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
