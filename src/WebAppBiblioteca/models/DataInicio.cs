using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppBiblioteca.models
{
    public static class DataInicio
    {
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.CategoriaLibros.Any())
            {
                //Categorias Libros Iniciales es una coleccion local
                contexto.CategoriaLibros.AddRange(CategoriasLibrosIniciales.Select(c => c.Value));
            }
            if (!contexto.Libros.Any())
            {
                contexto.AddRange
                (
                    new Libros { NombreLibro = "Cien caminos", DescripCortaLibro = "Obra Clasica", DescripLargaLibro = "Obra escrita en el año 1972 por un grande", PreCostoLibro = 20.0M, PreVentaLibro = 20.0M, ImagenURL = "/imagenes/libros/Portada.jpg", ImagenPreviaURL = "/imagenes/libros/Portada.jpg", LibroDestacado = true, LibroEnExistencia = true, EstadoLibro = true, CatLibros = CategoriasLibrosIniciales["Realista"] },
                    new Libros { NombreLibro = "Cien años", DescripCortaLibro = "Obra Clasica", DescripLargaLibro = "Obra escrita en el año 1969", PreCostoLibro = 20.0M, PreVentaLibro = 20.0M, ImagenURL = "/imagenes/libros/años.jpg", ImagenPreviaURL = "/imagenes/libros/años.jpg", LibroDestacado = true, LibroEnExistencia = true, EstadoLibro = true, CatLibros = CategoriasLibrosIniciales["Fantasia"] },
                    new Libros { NombreLibro = "Dracula", DescripCortaLibro = "Obra Clasica", DescripLargaLibro = "Obra escrita en el año 1969", PreCostoLibro = 20.0M, PreVentaLibro = 20.0M, ImagenURL = "/imagenes/libros/dracula.jpg", ImagenPreviaURL = "/imagenes/libros/dracula.jpg", LibroDestacado = true, LibroEnExistencia = true, EstadoLibro = true, CatLibros = CategoriasLibrosIniciales["Basado en hechos reales"] },
                    new Libros { NombreLibro = "años", DescripCortaLibro = "Obra Clasica", DescripLargaLibro = "Obra escrita en el año 1969", PreCostoLibro = 20.0M, PreVentaLibro = 20.0M, ImagenURL = "/imagenes/libros/cien.jpg", ImagenPreviaURL = "/imagenes/libros/cien.jpg", LibroDestacado = true, LibroEnExistencia = true, EstadoLibro = true, CatLibros = CategoriasLibrosIniciales["Basado en hechos reales"] }
                    
              );
            }

            contexto.SaveChanges();
        }//fin de agregarData

        //se hace referencia a la clase dominio CatLibrps
        public static Dictionary<string, CatLibros> catLibrosiniciales;
        public static Dictionary<string, CatLibros> CategoriasLibrosIniciales
        {
            get
            {
                if (catLibrosiniciales == null)
                {
                    var listadoCategorias = new CatLibros[]
                    {
                        new CatLibros {NombreCatLibro = "Realista"},
                        new CatLibros {NombreCatLibro = "Fantasia" },
                        new CatLibros {NombreCatLibro = "Basado en hechos reales" }
                    };
                    catLibrosiniciales = new Dictionary<string, CatLibros>();

                    foreach (CatLibros catlibini in listadoCategorias)
                    {
                        catLibrosiniciales.Add(catlibini.NombreCatLibro, catlibini);
                    }//fin del foreach
                }
                return catLibrosiniciales;
            }//fin del metodo get
        }//fin de diccionario de categorias
    }
}