using SalesManagement.Domain.Entities;
using SalesManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesManagement.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string descricao)
        {
            return dbContext.Produtos.Where(a => a.Descricao == descricao);
        }
    }
}
