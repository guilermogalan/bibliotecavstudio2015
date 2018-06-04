using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBiblioteca.models.usuarios;


namespace WebAppBiblioteca.viewmodels
{
    public class ListaUsuariosViewModel
    {
        public IEnumerable<usuarios> Usuarios { get; set; }
        public string Titulo { get; set; }
    }
}

