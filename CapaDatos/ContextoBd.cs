using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoBd : DbContext
    {
        public ContextoBd()
            : base("name=ContextoBd")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
    }
}
