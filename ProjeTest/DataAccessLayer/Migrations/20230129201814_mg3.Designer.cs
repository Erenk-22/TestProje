﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230129201814_mg3")]
    partial class mg3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.AdminPanel", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("AdminMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("adminPanels");
                });

            modelBuilder.Entity("EntityLayer.Concrete.KayitSistemi", b =>
                {
                    b.Property<int>("UyeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UyeID"));

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UyeDogümTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("UyeMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeTelefon")
                        .HasColumnType("int");

                    b.HasKey("UyeID");

                    b.ToTable("kayitSistemis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UyeCv", b =>
                {
                    b.Property<int>("CvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CvID"));

                    b.Property<string>("CvDosya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("CvID");

                    b.ToTable("uyeCvs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.UyeSorülar", b =>
                {
                    b.Property<int>("SorularID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SorularID"));

                    b.Property<string>("SoruAlti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruBes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruBir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruDokuz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruDort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruSekiz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruUc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoruYedi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soruİki")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("SorularID");

                    b.ToTable("uyeSorülars");
                });
#pragma warning restore 612, 618
        }
    }
}
