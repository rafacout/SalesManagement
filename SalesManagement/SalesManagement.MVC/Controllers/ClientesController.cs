using AutoMapper;
using SalesManagement.Application.Interfaces;
using SalesManagement.Domain.Entities;
using SalesManagement.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SalesManagement.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());

            return View(clienteViewModel);
        }

        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);

                    _clienteApp.Add(clienteDomain);

                    return RedirectToAction("Index");
                }

                return View(cliente);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Update(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
