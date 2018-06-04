using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebAppBiblioteca.models.usuarios
{
    public class NivelesUsuario
    {
        [Key]
        public int CodigoNivel { get; set; }

        public string NombreNivel { get; set; }
        public List<usuarios> Usuarios { get; set; }
    }
}


