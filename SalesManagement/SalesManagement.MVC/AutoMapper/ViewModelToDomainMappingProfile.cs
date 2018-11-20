using AutoMapper;
using SalesManagement.Domain.Entities;
using SalesManagement.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesManagement.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Pedido, PedidoViewModel>();
            Mapper.CreateMap<ItemPedido, ItemPedidoViewModel>();
        }
    }
}