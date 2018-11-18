using System;

namespace SalesManagement.Domain.Entities
{
    public class Produto
    {
        public long ProdutoId { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public bool Disponivel { get; set; }

        public double QuantidadeEstoque { get; set; }

    }
}
