using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesManagement.MVC.ViewModels
{
    public class PedidoViewModel
    {
        public PedidoViewModel()
        {
            this.ItensPedido = new List<ItemPedidoViewModel>();
        }

        [Key]
        public long PedidoId { get; set; }

        [Required]
        [DisplayName("Data Pedido")]
        public DateTime DataPedido { get; set; }

        [DisplayName("Cliente")]
        public long ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public virtual ICollection<ItemPedidoViewModel> ItensPedido { get; set; }

        public double ValorTotal { get; private set; }
        
    }
}