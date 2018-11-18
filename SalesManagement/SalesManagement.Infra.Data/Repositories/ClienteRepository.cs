using SalesManagement.Domain.Entities;
using SalesManagement.Domain.Interfaces.Repositories;
using System;

namespace SalesManagement.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
