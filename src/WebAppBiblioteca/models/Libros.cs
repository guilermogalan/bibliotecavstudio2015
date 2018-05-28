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
        public string DescripCortaLibro { get; set; }
        public string DescripLargaLibro { get; set; }
        public decimal PreCostoLibro { get; set; }
        public decimal PreVentaLibro{ get; set; }
        public string ImagenURL { get; set; }
        public string ImagenPreviaURL { get; set; }
        public bool LibroDestacado { get; set; }
        public bool LibroEnExistencia { get; set; }
        public bool EstadoLibro { get; set; }
        public int CodigoCategoria { get; set; }
        public virtual CatLibros CatLibros { get; set; }

    }
}
