using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesManagement.MVC.ViewModels
{
    public class ItemPedidoViewModel
    {
        [Key]
        public long ItemPedidoId { get; set; }

        public long PedidoId { get; set; }

        public long ProdutoId { get; set; }

        public double Quantidade { get; set; }

        public double PrecoUnitario { get; set; }

        public double ValorDesconto { get; set; }

        public virtual ProdutoViewModel Produto { get; set; }

        public virtual PedidoViewModel Pedido { get; set; }

    }
}