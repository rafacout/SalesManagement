using SalesManagement.Domain.Entities;
using System.Collections.Generic;

namespace SalesManagement.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
