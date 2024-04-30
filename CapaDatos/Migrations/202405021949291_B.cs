namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorias", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Marcas", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marcas", "Estado");
            DropColumn("dbo.Categorias", "Estado");
        }
    }
}
