using SalesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Infra.Data.EntityConfig
{
    public class ItemPedidoConfiguration : EntityTypeConfiguration<ItemPedido>
    {

        public ItemPedidoConfiguration()
        {
            HasKey(p => p.ItemPedidoId);


            Property(p => p.Quantidade)
                .IsRequired();

            Property(p => p.PrecoUnitario)
                .IsRequired();

            Property(p => p.ValorDesconto)
                .IsRequired();


            //Configuracao do relacionamento
            HasRequired(p => p.Pedido)
                .WithMany(i => i.ItensPedido)
                .HasForeignKey(p => p.PedidoId);
        }

    }
}
