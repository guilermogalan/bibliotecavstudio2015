using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppBiblioteca.models.usuarios
{
    public static class Datos
    {
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.NivUsuarios.Any())
            {
                //niveles usuarios es una coleccion local
                contexto.NivUsuarios.AddRange(NivelesUsuariosIniciales.Select(c => c.Value));
            }
            if (!contexto.Usuarios.Any())
            {
                contexto.AddRange
                    (
            new usuarios { NombreUsuario = "Rafael Chavez", UsernameUsuario = "adminrafa", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/rafa.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/rafa.jpg", CodigoNivel = 1, NivUsuarios = NivelesUsuariosIniciales["Administrador"] },
            new usuarios { NombreUsuario = "Neidy Yohami", UsernameUsuario = "biblioneidy", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/neidy.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/neidy.jpg", CodigoNivel = 2, NivUsuarios = NivelesUsuariosIniciales["Bibliotecario"] },
            new usuarios { NombreUsuario = "Guillermo Galan", UsernameUsuario = "adminguillermo", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/guillermo.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/guillermo.jpg", CodigoNivel = 1, NivUsuarios = NivelesUsuariosIniciales["Administrador"] },
            new usuarios { NombreUsuario = "Raul Alexis", UsernameUsuario = "superraul", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/raul.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/raul.jpg", CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["cliente"] },
            new usuarios { NombreUsuario = "Franklin Bermudez", UsernameUsuario = "franklin123", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/franklin.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/franklin.jpg", CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["cliente"] },
            new usuarios { NombreUsuario = "Carlos Solis", UsernameUsuario = "carlos123", DireccionUsuario = "SS", EstadoUsuario = "Activo", ImagenURL = "/Imagenes/usuarios/carlos.jpg", ImagenUsuarioURL = "/Imagenes/usuarios/carlos.jpg", CodigoNivel = 3, NivUsuarios = NivelesUsuariosIniciales["cliente"] }

                    );
            }
            contexto.SaveChanges();
        }
        public static Dictionary<string, NivelesUsuario> nivusuariosiniciales;
        public static Dictionary<string, NivelesUsuario> NivelesUsuariosIniciales
        {
            get
            {
                if (nivusuariosiniciales == null)
                {
                    var listadoNiveles = new NivelesUsuario[]
                    {
                        new NivelesUsuario  {NombreNivel = "Administrador" },
                        new NivelesUsuario  {NombreNivel = "Bibliotecario" },
                        new NivelesUsuario  {NombreNivel = "cliente" }
                    };
                    nivusuariosiniciales = new Dictionary<string, NivelesUsuario>();

                    foreach (NivelesUsuario nivusuini in listadoNiveles)
                    {
                        nivusuariosiniciales.Add(nivusuini.NombreNivel, nivusuini);
                    }//fin del foreach
                }
                return nivusuariosiniciales;
            }//fin del metodo get
        }//fin del diccionario de categorias
    }
}
