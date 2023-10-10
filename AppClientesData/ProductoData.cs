using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3erPreentrega;
using AppClientesEntities;

namespace AppClientesData
{
    public static class ProductoData
    {
        public static Producto ObtenerProducto(int id)
        {
            using (var context = new Contexto())
            {
                return context.Productos.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Producto> ListarProductos()
        {
            using (var context = new Contexto())
            {
                return context.Productos.ToList();
            }
        }

        public static void CrearProducto(Producto producto)
        {
            using (var context = new Contexto())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public static void ModificarProducto(int id, Producto productoNuevo)
        {
            using (var context = new Contexto())
            {
                var productoActual = context.Productos.FirstOrDefault(x => x.Id == id);
                if (productoActual != null)
                {
                    productoActual.Descripciones = productoNuevo.Descripciones;
                    productoActual.Costo = productoNuevo.Costo;
                    productoActual.PrecioVenta = productoNuevo.PrecioVenta;
                    productoActual.Stock = productoNuevo.Stock;
                    productoActual.IdUsuario = productoNuevo.IdUsuario;
                    context.SaveChanges();
                }
            }
        }

        public static void EliminarProducto(int id)
        {
            using (var context = new Contexto())
            {
                var productoActual = context.Productos.FirstOrDefault(x => x.Id == id);
                if (productoActual != null)
                {
                    context.Productos.Remove(productoActual);
                    context.SaveChanges();
                }
            }
        }
    }
}

