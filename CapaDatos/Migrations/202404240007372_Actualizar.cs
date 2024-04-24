namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actualizar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "Descripcion", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "Descripcion");
        }
    }
}
