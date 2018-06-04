using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppBiblioteca.models.usuarios;

namespace WebAppBiblioteca.models.usuarios
{
    public class usuarios
    {
        [Key]
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string UsernameUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public string EstadoUsuario { get; set; }
        public string ImagenURL { get; set; }
        public string ImagenUsuarioURL { get; set; }
        public int CodigoNivel { get; set; }
        public virtual NivelesUsuario NivUsuarios { get; set; }

        }
    }


