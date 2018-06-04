using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBiblioteca.models.usuarios;

namespace WebAppBiblioteca.models.usuarios
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public UsuariosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<usuarios> Usuarios
        {
            get
            {
                return _appDbContext.Usuarios.Include(u => u.NivUsuarios);
            }
        }

        public IEnumerable<usuarios> UsuariosPorNivel
        {
            get
            {
                return _appDbContext.Usuarios.Include(u => u.NivUsuarios);
            }
        }

        public usuarios GetusuariosPorCodigo(int Codigousuario)
        {
            return _appDbContext.Usuarios.FirstOrDefault(u => u.CodigoUsuario == Codigousuario);
        }
    }
}

