using AutoMapper;
using SalesManagement.Application.Interfaces;
using SalesManagement.Domain.Entities;
using SalesManagement.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesManagement.MVC.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;
        private readonly IPedidoAppService _pedidoApp;

        public PedidosController(IPedidoAppService pedidoApp, IClienteAppService clienteApp, IProdutoAppService produtoApp)
        {
            _pedidoApp = pedidoApp;
            _clienteApp = clienteApp;
            _produtoApp = produtoApp;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var clientes = _clienteApp.GetAll();
            var produtos = _produtoApp.GetAll();

            ViewData["Clientes"] = clientes.Select(Mapper.Map<Cliente, ClienteViewModel>);
            ViewData["Produtos"] = produtos.Select(Mapper.Map<Produto, ProdutoViewModel>);

            return View(new PedidoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoViewModel pedido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pedidoDomain = Mapper.Map<PedidoViewModel, Pedido>(pedido);

                    pedidoDomain.ItensPedido.Add(new ItemPedido() { ProdutoId = 1, Quantidade = 1, ValorDesconto = 0  });

                    _pedidoApp.Add(pedidoDomain);

                    return RedirectToAction("Index");
                }

                return View(pedido);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
