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

            if (!contexto.CategoriasLibros.Any())
            {
                //Categorias Libros Iniciales es una coleccion local
                contexto.CategoriasLibros.AddRange(CategoriasLibrosIniciales.Select(c => c.Value));
            }
            if (!contexto.Libros.Any())
            {
                contexto.AddRange
                (
                    new Libros { CodigoLibro = 1, NombreLibro = "Cien caminos", DescripLibro = "Ninguno", CodigoCategoria = 1, AutorLibro = "Guillermo", EditorialLibro = "nuevo mundo", EstadoLibro = 1 },
                    new Libros { CodigoLibro = 2, NombreLibro = "Hombre en Llamas", DescripLibro = "Edicion español", CodigoCategoria = 1, AutorLibro = "Facundo", EditorialLibro = "Los nobles", EstadoLibro = 1 },
                    new Libros { CodigoLibro = 3, NombreLibro = "El viejo y el mar", DescripLibro = "Edicion español", CodigoCategoria = 1, AutorLibro = "charles", EditorialLibro = "Azul", EstadoLibro = 1 },
                    new Libros { CodigoLibro = 4, NombreLibro = "Metamorfosis", DescripLibro = "Obras Clasicas", CodigoCategoria = 2, AutorLibro = "Fran kafka", EditorialLibro = "Recomendado", EstadoLibro = 0 },
                    new Libros { CodigoLibro = 5, NombreLibro = "la paz facil", DescripLibro = "Obras clasicas", CodigoCategoria = 2, AutorLibro = "Guillermo", EditorialLibro = "Los notables", EstadoLibro = 0 },
                    new Libros { CodigoLibro = 6, NombreLibro = "Un dia mas uno menos", DescripLibro = "Edicion español", CodigoCategoria = 2, AutorLibro = "Guillermo", EditorialLibro = "Los nobles", EstadoLibro = 0 },
                    new Libros { CodigoLibro = 7, NombreLibro = "A buen dia preocupate", DescripLibro = "Edicion español", CodigoCategoria = 2, AutorLibro = "Ernesto Glan", EditorialLibro = "Los notables", EstadoLibro = 0 },
                    new Libros { CodigoLibro = 8, NombreLibro = "Hombres pagando deuda femenina", DescripLibro = "Edicion Oro", CodigoCategoria = 3, AutorLibro = "Adan", EditorialLibro = "Balsamo", EstadoLibro = 1 },
                    new Libros { CodigoLibro = 9, NombreLibro = "Vivir porque?", DescripLibro = "Edicion español", CodigoCategoria = 3, AutorLibro = "Facundo Camus", EditorialLibro = "Los nobles", EstadoLibro = 1 },
                    new Libros { CodigoLibro = 10, NombreLibro = "Un buen viaje", DescripLibro = "Edicion Oro", CodigoCategoria = 3, AutorLibro = "Maria", EditorialLibro = "Los nobles", EstadoLibro = 0 },
                    new Libros { CodigoLibro = 11, NombreLibro = "Las cosas triviales", DescripLibro = "Edicion español", CodigoCategoria = 3, AutorLibro = "Enrique", EditorialLibro = "Los nobles", EstadoLibro = 1 }

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
                        new CatLibros {CodigoCatLibro = 1, NombreCatLibro = "Realista"},
                        new CatLibros {CodigoCatLibro = 2, NombreCatLibro = "Fantasia" },
                        new CatLibros {CodigoCatLibro = 3, NombreCatLibro = "Basado en hechos reales" }
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

