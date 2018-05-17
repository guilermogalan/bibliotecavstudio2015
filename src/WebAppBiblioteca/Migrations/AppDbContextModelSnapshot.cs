using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppBiblioteca.models;

namespace WebAppBiblioteca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppBiblioteca.models.CatLibros", b =>
                {
                    b.Property<int>("CodigoCatLibro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreCatLibro");

                    b.HasKey("CodigoCatLibro");

                    b.ToTable("CategoriasLibros");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.Libros", b =>
                {
                    b.Property<int>("CodigoLibro")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AutorLibro");

                    b.Property<int?>("CategoriasLibrosCodigoCatLibro");

                    b.Property<int>("CodigoCategoria");

                    b.Property<string>("DescripLibro");

                    b.Property<string>("EditorialLibro");

                    b.Property<int>("EstadoLibro");

                    b.Property<string>("NombreLibro");

                    b.HasKey("CodigoLibro");

                    b.HasIndex("CategoriasLibrosCodigoCatLibro");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebAppBiblioteca.models.Libros", b =>
                {
                    b.HasOne("WebAppBiblioteca.models.CatLibros", "CategoriasLibros")
                        .WithMany("Libros")
                        .HasForeignKey("CategoriasLibrosCodigoCatLibro");
                });
        }
    }
}
