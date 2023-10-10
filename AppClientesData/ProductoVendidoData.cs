using _3erPreentrega;
using AppClientesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppClientesData
{
    public static class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            using (var context = new Contexto())
            {
                return context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            using (var context = new Contexto())
            {
                return context.ProductosVendidos.ToList();
            }
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (var context = new Contexto())
            {
                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }

        public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoNuevo)
        {
            using (var context = new Contexto())
            {
                var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
                if (productoVendidoActual != null)
                {
                    productoVendidoActual.IdVenta = productoVendidoNuevo.IdVenta;
                    productoVendidoActual.Stock = productoVendidoNuevo.Stock;
                    productoVendidoActual.IdProducto = productoVendidoNuevo.IdProducto;
                    context.SaveChanges();
                }
            }
        }

        public static void EliminarProductoVendido(int id)
        {
            using (var context = new Contexto())
            {
                var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
                if (productoVendidoActual != null)
                {
                    context.ProductosVendidos.Remove(productoVendidoActual);
                    context.SaveChanges();
                }
            }
        }
    }
}

