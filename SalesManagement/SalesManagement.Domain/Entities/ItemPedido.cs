using System;

namespace SalesManagement.Domain.Entities
{
    public class ItemPedido
    {
        public long ItemPedidoId { get; set; }

        public long PedidoId { get; set; }

        public long ProdutoId { get; set; }

        public double Quantidade { get; set; }

        public double PrecoUnitario { get; set; }

        public double ValorDesconto { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
