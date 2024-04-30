namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productoes", "Precio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
