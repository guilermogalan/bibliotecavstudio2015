using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models.usuarios
{
    public interface INivelesUsuariosRepositorio
    {
        IEnumerable<NivelesUsuario> NivUsuarios { get; }
    }
}
