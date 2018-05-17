using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBiblioteca.models;

namespace WebAppBiblioteca.viewmodels
{
    public class ListaLibrosViewModel
    {

        public IEnumerable<Libros> Libros { get; set; }
        public string CategoriasLibros { get; set; }
    }
}