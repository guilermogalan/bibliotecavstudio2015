using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public interface ICatLibrosRepositorio
    {
        IEnumerable<CatLibros> CategoriaLibros { get; }

    }
}
