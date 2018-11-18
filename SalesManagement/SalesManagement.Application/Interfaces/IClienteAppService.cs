using SalesManagement.Domain.Entities;
using System.Collections.Generic;

namespace SalesManagement.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
