using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppClientesEntities;

namespace _3erPreentrega
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SistemaGestionEF;Trusted_Connection=True");

            }
            catch (Exception excepcion)
            {

                Console.WriteLine(excepcion);

            }
        }
    }
}


    
