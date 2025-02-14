﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presentation.DAL;

#nullable disable

namespace Presentation.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CsProjeDemo1.Entities.Abstraction.Kitap", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<int?>("UyeId")
                        .HasColumnType("int");

                    b.Property<int>("YayinYili")
                        .HasColumnType("int");

                    b.Property<string>("Yazar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.HasIndex("UyeId");

                    b.ToTable("Kitaplar");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("CsProjeDemo1.Entities.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UyeNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("CsProjeDemo1.Entities.Abstraction.Kitap", b =>
                {
                    b.HasOne("CsProjeDemo1.Entities.Uye", "Uye")
                        .WithMany("OduncKitaplar")
                        .HasForeignKey("UyeId");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("CsProjeDemo1.Entities.Uye", b =>
                {
                    b.Navigation("OduncKitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
