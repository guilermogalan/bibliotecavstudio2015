using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppBiblioteca.models;
using WebAppBiblioteca.viewmodels;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppBiblioteca.controllers
{
    public class LibrosController : Controller
    {
        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly ICatLibrosRepositorio _catlibrosRepositorio;
        private readonly ILibrosRepositorio _librosRepositorio;

        //constructor de esta clase controller
        public LibrosController(ICatLibrosRepositorio CatlibrosRepositorio, ILibrosRepositorio librosRepositorio)
        {
            _catlibrosRepositorio = CatlibrosRepositorio;
            _librosRepositorio = librosRepositorio;
        }//fin del constructor

        //metodo para devolver la vista con datos inyectados

        public ViewResult ListaLibros(string categoriasProductos)
        {
            //objetos para mostrar las categorias de los productos
            ListaLibrosViewModel listalibrosViewModel = new ListaLibrosViewModel();
            listalibrosViewModel.Libros = _librosRepositorio.Libros.Where(c => c.EstadoLibro == 0);

            //pasando intencionalmente un valor a la variedad de la clase
            listalibrosViewModel.CategoriasLibros = "Libros Realista";

            return View(listalibrosViewModel);
        }//fin del metodo lista libros


    }
}
