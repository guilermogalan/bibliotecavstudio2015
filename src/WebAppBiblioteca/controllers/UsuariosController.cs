using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppBiblioteca.models.usuarios;
using WebAppBiblioteca.viewmodels;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppBiblioteca.controllers
{
    public class UsuariosController : Controller
    {
        //Archivos de solo lectura

        private readonly IUsuariosRepositorio _usuariosRepositorio;
        //constructor
        public UsuariosController(IUsuariosRepositorio usuariosRepositorio)
        {

            _usuariosRepositorio = usuariosRepositorio;

        }//fin del constructor

        //metodo para devolver vista con datos inyectados
        public ViewResult ListaUsuarios()

        {
            //objeto para mostrar los usuarios
            ListaUsuariosViewModel listausuariosViewModel = new ListaUsuariosViewModel();
            listausuariosViewModel.Usuarios = _usuariosRepositorio.Usuarios;

            //
            listausuariosViewModel.Titulo = "Lista de Usuarios el Sistema";

            //  return View(_usuariosRepositorio.Usuarios);
            return View(listausuariosViewModel);
        }//fin del metodo ListaUsuarios
        public ViewResult ListaUsuariosPorNivel()
        {
            return View(_usuariosRepositorio.UsuariosPorNivel);

        }
    }
}