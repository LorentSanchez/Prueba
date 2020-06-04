﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Preueba.Web.Data.Entities;

namespace Prueba.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200603212629_preuba4")]
    partial class preuba4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Preueba.Web.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("StateId");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Preueba.Web.Models.Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("NeighborhoodName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("NeighborhoodId");

                    b.HasIndex("CityId");

                    b.ToTable("Neighborhood");
                });

            modelBuilder.Entity("Preueba.Web.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoC")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("DireccionC")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("NombreC")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("TelefonC")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("OwnerId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Preueba.Web.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Prueba.Web.Models.Articles", b =>
                {
                    b.Property<int>("ArticlesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtcId");

                    b.Property<string>("ArticlesName")
                        .IsRequired();

                    b.Property<int>("BrandId");

                    b.HasKey("ArticlesId");

                    b.HasIndex("ArtcId")
                        .IsUnique();

                    b.HasIndex("BrandId")
                        .IsUnique();

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Prueba.Web.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Prueba.Web.Models.ClassificationArt", b =>
                {
                    b.Property<int>("ArtcId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameArtc")
                        .IsRequired();

                    b.HasKey("ArtcId");

                    b.ToTable("ClassificationArt");
                });

            modelBuilder.Entity("Prueba.Web.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Prueba.Web.Models.TypeDocument", b =>
                {
                    b.Property<int>("IdDocumet")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Document")
                        .IsRequired();

                    b.Property<int?>("OwnerId");

                    b.Property<string>("TypeDocum")
                        .IsRequired();

                    b.HasKey("IdDocumet");

                    b.HasIndex("OwnerId");

                    b.ToTable("TypeDocument");
                });

            modelBuilder.Entity("Preueba.Web.Models.City", b =>
                {
                    b.HasOne("Preueba.Web.Models.State", "States")
                        .WithMany("Citys")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Preueba.Web.Models.Neighborhood", b =>
                {
                    b.HasOne("Preueba.Web.Models.City", "Citys")
                        .WithMany("Neighborhoods")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Preueba.Web.Models.State", b =>
                {
                    b.HasOne("Prueba.Web.Models.Country", "Countrys")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prueba.Web.Models.Articles", b =>
                {
                    b.HasOne("Prueba.Web.Models.ClassificationArt", "ClassificationArts")
                        .WithOne("Articles")
                        .HasForeignKey("Prueba.Web.Models.Articles", "ArtcId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prueba.Web.Models.Brand", "Brands")
                        .WithOne("Articles")
                        .HasForeignKey("Prueba.Web.Models.Articles", "BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prueba.Web.Models.TypeDocument", b =>
                {
                    b.HasOne("Preueba.Web.Models.Owner")
                        .WithMany("TypeDocuments")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
