using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.models.usuarios
{
    public class MockUsuariosRepositorio : IUsuariosRepositorio
    {
        public IEnumerable<usuarios> Usuarios
        {
            get
            {
                return new List<usuarios>
         {
            new usuarios {CodigoUsuario=1, NombreUsuario="Rafael Chavez", UsernameUsuario="adminrafa", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=1 },
            new usuarios {CodigoUsuario=2, NombreUsuario="Neidy Yohami", UsernameUsuario="biblioneidy", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=2 },
            new usuarios {CodigoUsuario=3, NombreUsuario="Guillermo Galan", UsernameUsuario="adminguillermo", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=1 },
            new usuarios {CodigoUsuario=4, NombreUsuario="Raul Alexis", UsernameUsuario="superraul", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=3 },
            new usuarios {CodigoUsuario=5, NombreUsuario="Franklin Bermudez", UsernameUsuario="franklin123", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=4 },
            new usuarios {CodigoUsuario=6, NombreUsuario="Carlos Solis", UsernameUsuario="carlos123", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=4 }
              };
            }//fin del get
        }//fin del ienumerable
        public IEnumerable<usuarios> UsuariosPorNivel
        {
            get
            {
                return new List<usuarios>
                {
                new usuarios {CodigoUsuario=1, NombreUsuario="Rafael Chavez", UsernameUsuario="adminrafa", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=1 },
                new usuarios {CodigoUsuario=3, NombreUsuario="Guillermo Galan", UsernameUsuario="adminguillermo", DireccionUsuario="SS", EstadoUsuario="Activo", CodigoNivel=1 }
                };


            }

        }

        public usuarios GetusuariosPorCodigo(int Codigousuario)
        {
            throw new NotImplementedException();
        }

        public usuarios GetUsuariosPorCodigo(int CodigoUsuario)
        {
            throw new System.NotImplementedException();
        }
    }//fin del public class

}
