namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        IdDetalleVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                        idMetodoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleVenta)
                .ForeignKey("dbo.MetodoPagoes", t => t.idMetodoPago, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.VentaId)
                .Index(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.MetodoPagoes",
                c => new
                    {
                        idMetodoPago = c.Int(nullable: false, identity: true),
                        FormaDePago = c.String(nullable: false, maxLength: 60),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Existencias = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Activo = c.Boolean(nullable: false),
                        idMarca = c.Int(nullable: false),
                        idCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Categorias", t => t.idCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.idMarca, cascadeDelete: true)
                .Index(t => t.idMarca)
                .Index(t => t.idCategoria);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        idMarca = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idMarca);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.DetalleVentas", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "idMarca", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "idCategoria", "dbo.Categorias");
            DropForeignKey("dbo.DetalleVentas", "idMetodoPago", "dbo.MetodoPagoes");
            DropIndex("dbo.Productoes", new[] { "idCategoria" });
            DropIndex("dbo.Productoes", new[] { "idMarca" });
            DropIndex("dbo.DetalleVentas", new[] { "idMetodoPago" });
            DropIndex("dbo.DetalleVentas", new[] { "VentaId" });
            DropIndex("dbo.DetalleVentas", new[] { "ProductoId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.MetodoPagoes");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Categorias");
        }
    }
}
