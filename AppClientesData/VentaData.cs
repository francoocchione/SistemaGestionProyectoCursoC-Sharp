using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3erPreentrega;
using AppClientesEntities;

namespace AppClientesData
{
    public static class VentaData
    {
        public static Venta ObtenerVenta(int id)
        {
            using (var context = new Contexto())
            {
                return context.Ventas.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Venta> ListarVentas()
        {
            using (var context = new Contexto())
            {
                return context.Ventas.ToList();
            }
        }

        public static void CrearVenta(Venta venta)
        {
            using (var context = new Contexto())
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
            }
        }

        public static void ModificarVenta(int id, Venta ventaNueva)
        {
            using (var context = new Contexto())
            {
                var ventaActual = context.Ventas.FirstOrDefault(x => x.Id == id);
                if (ventaActual != null)
                {
                    ventaActual.Comentarios = ventaNueva.Comentarios;
                    ventaActual.IdUsuario = ventaNueva.IdUsuario;
                    context.SaveChanges();
                }
            }
        }

        public static void EliminarVenta(int id)
        {
            using (var context = new Contexto())
            {
                var ventaActual = context.Ventas.FirstOrDefault(x => x.Id == id);
                if (ventaActual != null)
                {
                    context.Ventas.Remove(ventaActual);
                    context.SaveChanges();
                }
            }
        }
    }
}
     
