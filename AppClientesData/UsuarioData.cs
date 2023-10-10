using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3erPreentrega;
using AppClientesEntities;

namespace AppClientesData
{
    public static class UsuarioData
    {
        public static Usuario ObtenerUsuario(int id)
        {
            using (var context = new Contexto())
            {
                return context.Usuarios.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Usuario> ListarUsuarios()
        {
            using (var context = new Contexto())
            {
                return context.Usuarios.ToList();
            }
        }

        public static void CrearUsuario(Usuario usuario)
        {
            using (var context = new Contexto())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public static void ModificarUsuario(int id, Usuario usuarioNuevo)
        {
            using (var context = new Contexto())
            {
                var usuarioActual = context.Usuarios.FirstOrDefault(x => x.Id == id);
                if (usuarioActual != null)
                {
                    usuarioActual.Nombre = usuarioNuevo.Nombre;
                    usuarioActual.NombreUsuario = usuarioNuevo.NombreUsuario;
                    usuarioActual.Apellido = usuarioNuevo.Apellido;
                    usuarioActual.Mail = usuarioNuevo.Mail;
                    usuarioActual.Contrasenia = usuarioNuevo.Contrasenia;
                    context.SaveChanges();
                }
            }
        }

        public static void EliminarUsuario(int id)
        {
            using (var context = new Contexto())
            {
                var usuarioActual = context.Usuarios.FirstOrDefault(x => x.Id == id);
                if (usuarioActual != null)
                {
                    context.Usuarios.Remove(usuarioActual);
                    context.SaveChanges();
                }
            }
        }
    }
}
