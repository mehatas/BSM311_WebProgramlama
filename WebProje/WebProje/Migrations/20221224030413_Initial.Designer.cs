﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProje.Data;

#nullable disable

namespace WebProje.Migrations
{
    [DbContext(typeof(Veritabani))]
    [Migration("20221224030413_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebProje.Models.Aktor_Film", b =>
                {
                    b.Property<int>("AktorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("AktorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("Aktor_Filmler");
                });

            modelBuilder.Entity("WebProje.Models.Aktorler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biyografi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilFotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aktorler");
                });

            modelBuilder.Entity("WebProje.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AfisURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Baslangic")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Bitis")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kategori")
                        .HasColumnType("int");

                    b.Property<int>("SinemaId")
                        .HasColumnType("int");

                    b.Property<int>("YapimciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SinemaId");

                    b.HasIndex("YapimciId");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("WebProje.Models.Sinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sinemalar");
                });

            modelBuilder.Entity("WebProje.Models.Yapimcilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biyografi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilFotoURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yapimcilar");
                });

            modelBuilder.Entity("WebProje.Models.Aktor_Film", b =>
                {
                    b.HasOne("WebProje.Models.Aktorler", "Aktor")
                        .WithMany("Aktor_Filmler")
                        .HasForeignKey("AktorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Film", "Film")
                        .WithMany("Aktor_Filmler")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aktor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("WebProje.Models.Film", b =>
                {
                    b.HasOne("WebProje.Models.Sinema", "Sinema")
                        .WithMany()
                        .HasForeignKey("SinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProje.Models.Yapimcilar", "Yapimci")
                        .WithMany("Filmler")
                        .HasForeignKey("YapimciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinema");

                    b.Navigation("Yapimci");
                });

            modelBuilder.Entity("WebProje.Models.Aktorler", b =>
                {
                    b.Navigation("Aktor_Filmler");
                });

            modelBuilder.Entity("WebProje.Models.Film", b =>
                {
                    b.Navigation("Aktor_Filmler");
                });

            modelBuilder.Entity("WebProje.Models.Yapimcilar", b =>
                {
                    b.Navigation("Filmler");
                });
#pragma warning restore 612, 618
        }
    }
}
