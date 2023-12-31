﻿// <auto-generated />
using System;
using Axede.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Axede.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Axede.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadHotel")
                        .HasColumnType("int");

                    b.Property<int>("Estandar")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Premium")
                        .HasColumnType("int");

                    b.Property<int>("Vip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hoteles");
                });

            modelBuilder.Entity("Axede.Models.Reservas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaFinReserva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioReserva")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Axede.Models.Valor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capa_Estan")
                        .HasColumnType("int");

                    b.Property<int>("Capa_Pre")
                        .HasColumnType("int");

                    b.Property<int>("Capa_Vip")
                        .HasColumnType("int");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<int>("Valor_Estan")
                        .HasColumnType("int");

                    b.Property<int>("Valor_Pre")
                        .HasColumnType("int");

                    b.Property<int>("Valor_Vip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Valores");
                });

            modelBuilder.Entity("Axede.Models.Reservas", b =>
                {
                    b.HasOne("Axede.Models.Hotel", null)
                        .WithMany("Reservas")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("Axede.Models.Valor", b =>
                {
                    b.HasOne("Axede.Models.Hotel", null)
                        .WithMany("Valor")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("Axede.Models.Hotel", b =>
                {
                    b.Navigation("Reservas");

                    b.Navigation("Valor");
                });
#pragma warning restore 612, 618
        }
    }
}
