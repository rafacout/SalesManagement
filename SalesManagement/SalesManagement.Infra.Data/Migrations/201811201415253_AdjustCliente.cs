namespace SalesManagement.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustCliente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
            DropPrimaryKey("dbo.Cliente");
            AlterColumn("dbo.Cliente", "ClienteId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Pedido", "ClienteId", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Cliente", "ClienteId");
            CreateIndex("dbo.Pedido", "ClienteId");
            AddForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente", "ClienteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
            DropPrimaryKey("dbo.Cliente");
            AlterColumn("dbo.Pedido", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "ClienteId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cliente", "ClienteId");
            CreateIndex("dbo.Pedido", "ClienteId");
            AddForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente", "ClienteId");
        }
    }
}
