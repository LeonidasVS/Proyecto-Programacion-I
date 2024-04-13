using Capa_Entidades;
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


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Detalle_Venta> Detalle { get; set; }
        public virtual DbSet<MetodoPago> Metodo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
    }
}
