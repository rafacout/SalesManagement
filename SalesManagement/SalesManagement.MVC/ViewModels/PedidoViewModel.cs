using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesManagement.MVC.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public long PedidoId { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        public long ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public virtual ICollection<ItemPedidoViewModel> ItensPedido { get; set; }

        public double ValorTotal { get; private set; }
        
    }
}