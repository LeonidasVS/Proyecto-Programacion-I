namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correcioncita : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productoes", "Cantidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "Cantidad", c => c.Int(nullable: false));
        }
    }
}
