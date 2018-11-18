using SalesManagement.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SalesManagement.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
