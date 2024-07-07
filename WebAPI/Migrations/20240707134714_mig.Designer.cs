﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(OkulContext))]
    [Migration("20240707134714_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.Property<int>("AldigiDerslerId")
                        .HasColumnType("int");

                    b.Property<int>("DersiAlanOgrencilerId")
                        .HasColumnType("int");

                    b.HasKey("AldigiDerslerId", "DersiAlanOgrencilerId");

                    b.HasIndex("DersiAlanOgrencilerId");

                    b.ToTable("DersOgrenci");
                });

            modelBuilder.Entity("WebAPI.Models.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersKontenjani")
                        .HasColumnType("int");

                    b.Property<int>("DersiVerenOgretimElemaniId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersiVerenOgretimElemaniId");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("WebAPI.Models.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("OgrenciNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("WebAPI.Models.OgretimElemani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SicilNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OgretimElemanlari");
                });

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.HasOne("WebAPI.Models.Ders", null)
                        .WithMany()
                        .HasForeignKey("AldigiDerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Ogrenci", null)
                        .WithMany()
                        .HasForeignKey("DersiAlanOgrencilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Models.Ders", b =>
                {
                    b.HasOne("WebAPI.Models.OgretimElemani", "DersiVerenOgretimElemani")
                        .WithMany("VerdigiDersler")
                        .HasForeignKey("DersiVerenOgretimElemaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DersiVerenOgretimElemani");
                });

            modelBuilder.Entity("WebAPI.Models.OgretimElemani", b =>
                {
                    b.Navigation("VerdigiDersler");
                });
#pragma warning restore 612, 618
        }
    }
}