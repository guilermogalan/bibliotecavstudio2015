using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public class CatLibros
    {
        [Key]
        public int CodigoCatLibro { get; set; }
        public string NombreCatLibro { get; set; }
        public List<Libros> Libros { get; set; }

    }
}
