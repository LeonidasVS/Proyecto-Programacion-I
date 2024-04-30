namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conexion : DbMigration
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
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.Detalle_Venta",
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
                        FormaDePago = c.String(nullable: false, maxLength: 60),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        idProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 200),
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
                        Estado = c.Boolean(nullable: false),
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
            DropForeignKey("dbo.Detalle_Venta", "idVenta", "dbo.Ventas");
            DropForeignKey("dbo.Detalle_Venta", "idProducto", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "idMarca", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "idCategoria", "dbo.Categorias");
            DropForeignKey("dbo.Detalle_Venta", "idMetodoPago", "dbo.MetodoPagoes");
            DropIndex("dbo.Productoes", new[] { "idCategoria" });
            DropIndex("dbo.Productoes", new[] { "idMarca" });
            DropIndex("dbo.Detalle_Venta", new[] { "idMetodoPago" });
            DropIndex("dbo.Detalle_Venta", new[] { "idVenta" });
            DropIndex("dbo.Detalle_Venta", new[] { "idProducto" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.MetodoPagoes");
            DropTable("dbo.Detalle_Venta");
            DropTable("dbo.Categorias");
        }
    }
}
