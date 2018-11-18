using SalesManagement.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SalesManagement.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}