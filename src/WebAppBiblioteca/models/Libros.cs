using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models
{
    public class Libros
    {
        [Key]
        public int CodigoLibro { get; set; }
        public string NombreLibro { get; set; }
        public string DescripLibro { get; set; }
        public int CodigoCategoria { get; set; }
        public string AutorLibro { get; set; }
        public string EditorialLibro { get; set; }
        public int EstadoLibro { get; set; }
        public virtual CatLibros CategoriasLibros { get; set; }

    }
}
