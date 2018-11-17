using SalesManagement.Domain.Entities;
using System.Data.Entity;

namespace SalesManagement.Infra.Data.Context
{
    public class SalesManagementContext : DbContext
    {
        public SalesManagementContext() : base("SalesManagement")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
