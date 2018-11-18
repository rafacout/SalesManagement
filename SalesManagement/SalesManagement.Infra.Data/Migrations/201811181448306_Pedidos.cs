namespace SalesManagement.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pedidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        ItemPedidoId = c.Long(nullable: false, identity: true),
                        PedidoId = c.Long(nullable: false),
                        ProdutoId = c.Long(nullable: false),
                        Quantidade = c.Double(nullable: false),
                        PrecoUnitario = c.Double(nullable: false),
                        ValorDesconto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ItemPedidoId)
                .ForeignKey("dbo.Pedido", t => t.PedidoId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.PedidoId)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        PedidoId = c.Long(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        QuantidadeEstoque = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemPedido", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.ItemPedido", "PedidoId", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Pedido", new[] { "ClienteId" });
            DropIndex("dbo.ItemPedido", new[] { "ProdutoId" });
            DropIndex("dbo.ItemPedido", new[] { "PedidoId" });
            DropTable("dbo.Produto");
            DropTable("dbo.Pedido");
            DropTable("dbo.ItemPedido");
        }
    }
}
