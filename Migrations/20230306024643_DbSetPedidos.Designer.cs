﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monitores_WebApp;

#nullable disable

namespace Monitores_WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230306024643_DbSetPedidos")]
    partial class DbSetPedidos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Monitores_WebApp.Entities.Monitors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Frecuencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<string>("Pulgadas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolución")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Monitores");
                });

            modelBuilder.Entity("Monitores_WebApp.Entities.Pedidos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Descripcion")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Pedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_Monitor")
                        .HasColumnType("int");

                    b.Property<int?>("monitoresId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("monitoresId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("Monitores_WebApp.Entities.Pedidos", b =>
                {
                    b.HasOne("Monitores_WebApp.Entities.Monitors", "monitores")
                        .WithMany("pedidos")
                        .HasForeignKey("monitoresId");

                    b.Navigation("monitores");
                });

            modelBuilder.Entity("Monitores_WebApp.Entities.Monitors", b =>
                {
                    b.Navigation("pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}