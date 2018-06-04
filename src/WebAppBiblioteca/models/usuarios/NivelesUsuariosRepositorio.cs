using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBiblioteca.models.usuarios;


namespace WebAppBiblioteca.models.usuarios
{
    public class NivelesUsuariosRepositorio : INivelesUsuariosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public NivelesUsuariosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }//fin constructor
        public IEnumerable<NivelesUsuario> NivUsuarios => _appDbContext.NivUsuarios;
    }
}
