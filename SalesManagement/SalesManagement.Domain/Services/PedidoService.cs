using System.Collections.Generic;
using SalesManagement.Domain.Entities;
using SalesManagement.Domain.Interfaces.Repositories;
using SalesManagement.Domain.Interfaces.Services;
using System.Linq;

namespace SalesManagement.Domain.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository) 
            : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
    }
}
