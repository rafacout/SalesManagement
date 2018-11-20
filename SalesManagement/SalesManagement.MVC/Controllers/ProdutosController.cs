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
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;

        public ProdutosController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _produtoApp = produtoApp;
            _clienteApp = clienteApp;
        }

        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());

            return View(produtoViewModel);
        }

        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                    _produtoApp.Add(produtoDomain);

                    return RedirectToAction("Index");
                }

                return View(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}