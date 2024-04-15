namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        IdDetalleVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleVenta)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.VentaId);
            
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
                    })
                .PrimaryKey(t => t.IdProducto);
            
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
            DropIndex("dbo.DetalleVentas", new[] { "VentaId" });
            DropIndex("dbo.DetalleVentas", new[] { "ProductoId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetalleVentas");
        }
    }
}
