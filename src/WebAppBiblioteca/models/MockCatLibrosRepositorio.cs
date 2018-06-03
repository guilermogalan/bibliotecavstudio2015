using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBiblioteca.models;

namespace WebAppBiblioteca.models
{
    public class MockCatLibrosRepositorio : ICatLibrosRepositorio
    {
        public IEnumerable<CatLibros> CategoriaLibros
        {
            get
            {
                return new List<CatLibros>
                {
                    new CatLibros {CodigoCatLibro = 1, NombreCatLibro = "Realista", DescripcionCatLibro = "basado en la historia de emilio raz"},
                    new CatLibros {CodigoCatLibro = 2, NombreCatLibro = "Fantasia", DescripcionCatLibro = "libro escrito por margareth null" },
                    new CatLibros {CodigoCatLibro = 3, NombreCatLibro = "Basado en hechos reales", DescripcionCatLibro = "de la historia de la juventud de 21" }
                };
            }//FIN DEL GET
        }//fin del IEnumerable
    }//fin de public class
}

