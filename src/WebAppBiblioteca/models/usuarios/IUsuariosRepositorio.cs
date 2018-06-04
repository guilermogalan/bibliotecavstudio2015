using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models.usuarios
{
    public interface IUsuariosRepositorio
    {
        IEnumerable<usuarios> Usuarios { get; }
        IEnumerable<usuarios> UsuariosPorNivel { get; }

        usuarios GetusuariosPorCodigo(int Codigousuario);

    }
}

