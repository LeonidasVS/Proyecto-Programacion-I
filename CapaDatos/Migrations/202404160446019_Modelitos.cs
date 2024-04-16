namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelitos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        idDetalleVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        idProducto = c.Int(nullable: false),
                        idVenta = c.Int(nullable: false),
                        idMetodoPago = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDetalleVenta)
                .ForeignKey("dbo.MetodoPagoes", t => t.idMetodoPago, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.idProducto, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.idVenta, cascadeDelete: true)
                .Index(t => t.idProducto)
                .Index(t => t.idVenta)
                .Index(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.MetodoPagoes",
                c => new
                    {
                        idMetodoPago = c.Int(nullable: false, identity: true),
                        FormaPago = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        idProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Cantidad = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        idMarca = c.Int(nullable: false),
                        idCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProducto)
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
                    })
                .PrimaryKey(t => t.idMarca);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        idVenta = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idVenta);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "idVenta", "dbo.Ventas");
            DropForeignKey("dbo.DetalleVentas", "idProducto", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "idMarca", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "idCategoria", "dbo.Categorias");
            DropForeignKey("dbo.DetalleVentas", "idMetodoPago", "dbo.MetodoPagoes");
            DropIndex("dbo.Productoes", new[] { "idCategoria" });
            DropIndex("dbo.Productoes", new[] { "idMarca" });
            DropIndex("dbo.DetalleVentas", new[] { "idMetodoPago" });
            DropIndex("dbo.DetalleVentas", new[] { "idVenta" });
            DropIndex("dbo.DetalleVentas", new[] { "idProducto" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.MetodoPagoes");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Categorias");
        }
    }
}
