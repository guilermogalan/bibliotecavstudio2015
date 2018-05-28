using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public class MockLibrosRepositorio : ILibrosRepositorio
    {
        private readonly ICatLibrosRepositorio _CategoriasRepositorio = new MockCatLibrosRepositorio();

        public IEnumerable<Libros> Libros
        {
            get
            {
                return new List<Libros>
                {
                    new Libros {CodigoLibro = 1, NombreLibro = "Cien caminos", DescripLibro = "Ninguno", PreCostoLibro = 30.0M, PreVentaLibro = 30.0M, EstadoLibro = true, CodigoCategoria = 1  },
                    new Libros {CodigoLibro = 1, NombreLibro = "La Noche" , DescripLibro = "Edicion Castellano", PreCostoLibro = 25.0M, PreVentaLibro = 25.0M, EstadoLibro = true, CodigoCategoria = 2 }
                    
                };
            }//fin del get
        }//fin de IEnumerable Libros

        public IEnumerable<Libros> LibroDestacadosLectores { get; }
        public Libros GetLibrosPorCodigo(int CodigoLibro)
        {
            throw new System.NotImplementedException();
        }

    }//fin de public class
}
