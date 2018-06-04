using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models.usuarios
{
    public class MockNivelesUsuariosRepositorio : INivelesUsuariosRepositorio
    {
        public IEnumerable<NivelesUsuario> NivUsuarios
        {
            get
            {
                return new List<NivelesUsuario>
                {
                    new NivelesUsuario {CodigoNivel=1, NombreNivel="Administrador" },
                    new NivelesUsuario {CodigoNivel=2, NombreNivel="Bibliotecario" },
                    new NivelesUsuario {CodigoNivel=3, NombreNivel="Supervisor"},
                    new NivelesUsuario {CodigoNivel=4, NombreNivel="Cliente" }
                };

            }//fin del get
        }//fin del ienumerable

    }//fin del public class
}