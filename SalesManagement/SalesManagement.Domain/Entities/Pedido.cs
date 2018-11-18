using System;
using System.Collections.Generic;

namespace SalesManagement.Domain.Entities
{
    public class Pedido
    {
        public long PedidoId { get; set; }

        public DateTime DataPedido { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public double ValorTotal { get; private set; }
    }
}
