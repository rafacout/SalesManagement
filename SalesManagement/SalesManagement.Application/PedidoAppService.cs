using SalesManagement.Application.Interfaces;
using SalesManagement.Domain.Entities;
using SalesManagement.Domain.Interfaces.Services;

namespace SalesManagement.Application
{
    public class PedidoAppService : AppServiceBase<Pedido>, IPedidoAppService
    {
        private readonly IPedidoService _pedidoService;

        public PedidoAppService(IPedidoService pedidoService)
            : base(pedidoService)
        {
            _pedidoService = pedidoService;
        }
    }
}
