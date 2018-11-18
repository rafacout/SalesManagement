namespace SalesManagement.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adjusts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produto", "Valor", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
