using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public class LibrosRepositorio : ILibrosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public LibrosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Libros> Libros
        {
            get
            {
                return _appDbContext.Libros.Include(c => c.CatLibros);
            }
        }

        public IEnumerable<Libros> LibroDestacadosLectores
        {
            get
            {
                return _appDbContext.Libros.Include(c => c.CatLibros).Where(p => p.LibroDestacado);
            }
        }

        public Libros GetLibrosPorCodigo(int CodigoLibro)
        {
            return _appDbContext.Libros.FirstOrDefault(p => p.CodigoLibro == CodigoLibro);
        }
    }
}

