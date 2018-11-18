namespace SalesManagement.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustEstoque : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produto", "QuantidadeEstoque", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "QuantidadeEstoque", c => c.Single(nullable: false));
        }
    }
}
