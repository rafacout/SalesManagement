using SalesManagement.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SalesManagement.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string descricao);
    }
}
