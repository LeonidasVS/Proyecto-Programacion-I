using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoBD : DbContext
    {
        public ContextoBD()
            : base("name=ContextoBD")
        {
        }

        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    }
}
