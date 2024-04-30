namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActPre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "PrecioUnitario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "PrecioUnitario");
        }
    }
}
