using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public interface ILibrosRepositorio
    {
        IEnumerable<Libros> Libros { get; }
        IEnumerable<Libros> LibroOferta { get; }
        Libros GetLibrosPorCodigo(int CodigoLibro);

    }
}
