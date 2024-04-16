namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nuevas_Tablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MetodoPagoes",
                c => new
                    {
                        idMetodoPago = c.Int(nullable: false, identity: true),
                        FormaDePago = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.idMetodoPago);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        idMarca = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.idMarca);
            
            AddColumn("dbo.DetalleVentas", "idMetodoPago", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "idMarca", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "idCategoria", c => c.Int(nullable: false));
            CreateIndex("dbo.DetalleVentas", "idMetodoPago");
            CreateIndex("dbo.Productoes", "idMarca");
            CreateIndex("dbo.Productoes", "idCategoria");
            AddForeignKey("dbo.DetalleVentas", "idMetodoPago", "dbo.MetodoPagoes", "idMetodoPago", cascadeDelete: true);
            AddForeignKey("dbo.Productoes", "idCategoria", "dbo.Categorias", "idCategoria", cascadeDelete: true);
            AddForeignKey("dbo.Productoes", "idMarca", "dbo.Marcas", "idMarca", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productoes", "idMarca", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "idCategoria", "dbo.Categorias");
            DropForeignKey("dbo.DetalleVentas", "idMetodoPago", "dbo.MetodoPagoes");
            DropIndex("dbo.Productoes", new[] { "idCategoria" });
            DropIndex("dbo.Productoes", new[] { "idMarca" });
            DropIndex("dbo.DetalleVentas", new[] { "idMetodoPago" });
            DropColumn("dbo.Productoes", "idCategoria");
            DropColumn("dbo.Productoes", "idMarca");
            DropColumn("dbo.DetalleVentas", "idMetodoPago");
            DropTable("dbo.Marcas");
            DropTable("dbo.Categorias");
            DropTable("dbo.MetodoPagoes");
        }
    }
}
