﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppBiblioteca.models;

namespace WebAppBiblioteca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180604204555_Datos")]
    partial class Datos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppBiblioteca.models.CatLibros", b =>
                {
                    b.Property<int>("CodigoCatLibro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionCatLibro");

                    b.Property<string>("NombreCatLibro");

                    b.HasKey("CodigoCatLibro");

                    b.ToTable("CategoriaLibros");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.Libros", b =>
                {
                    b.Property<int>("CodigoLibro")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CatLibrosCodigoCatLibro");

                    b.Property<int>("CodigoCategoria");

                    b.Property<string>("DescripCortaLibro");

                    b.Property<string>("DescripLargaLibro");

                    b.Property<string>("DescripLibro");

                    b.Property<bool>("EstadoLibro");

                    b.Property<string>("ImagenPreviaURL");

                    b.Property<string>("ImagenURL");

                    b.Property<bool>("LibroDestacado");

                    b.Property<bool>("LibroEnExistencia");

                    b.Property<string>("NombreLibro");

                    b.Property<decimal>("PreCostoLibro");

                    b.Property<decimal>("PreVentaLibro");

                    b.HasKey("CodigoLibro");

                    b.HasIndex("CatLibrosCodigoCatLibro");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.usuarios.NivelesUsuario", b =>
                {
                    b.Property<int>("CodigoNivel")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreNivel");

                    b.HasKey("CodigoNivel");

                    b.ToTable("NivUsuarios");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.usuarios.usuarios", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodigoNivel");

                    b.Property<string>("DireccionUsuario");

                    b.Property<string>("EstadoUsuario");

                    b.Property<string>("ImagenURL");

                    b.Property<string>("ImagenUsuarioURL");

                    b.Property<string>("NombreUsuario");

                    b.Property<string>("UsernameUsuario");

                    b.HasKey("CodigoUsuario");

                    b.HasIndex("CodigoNivel");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.Libros", b =>
                {
                    b.HasOne("WebAppBiblioteca.models.CatLibros", "CatLibros")
                        .WithMany("Libros")
                        .HasForeignKey("CatLibrosCodigoCatLibro");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.usuarios.usuarios", b =>
                {
                    b.HasOne("WebAppBiblioteca.models.usuarios.NivelesUsuario", "NivUsuarios")
                        .WithMany("Usuarios")
                        .HasForeignKey("CodigoNivel")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
