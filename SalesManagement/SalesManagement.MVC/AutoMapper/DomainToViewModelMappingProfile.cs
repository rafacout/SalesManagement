using AutoMapper;
using SalesManagement.Domain.Entities;
using SalesManagement.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagement.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<PedidoViewModel, Pedido>();
            Mapper.CreateMap<ItemPedidoViewModel, ItemPedido>();
        }
    }
}