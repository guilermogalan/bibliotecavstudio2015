﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//operaciones con las conexiones

namespace WebAppBiblioteca.models
{
    public class CatLibrosRepositorio: ICatLibrosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        //metodo constructor 
        public CatLibrosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }//fin del constructor

        //extension de los metodos disponibles en la clase interface
        public IEnumerable<CatLibros> CategoriaLibros => _appDbContext.CategoriaLibros;
    }
}

