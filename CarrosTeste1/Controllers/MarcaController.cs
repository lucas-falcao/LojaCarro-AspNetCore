using CarrosTeste1.Models;
using CarrosTeste1.Repositorio;
using CarrosTeste1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosTeste1.Controllers
{
    public class MarcaController : Controller
    {
        private IRepository repo;

        public MarcaController(IRepository repository)
        {
            repo = repository;
        }
        public IActionResult Index()
        {
            var marcas = new CarrosViewModels();
            marcas.marcas = repo.GetMarcas();
            return View(marcas);
        }

        [HttpGet]
        public IActionResult Registro()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Marca marca)
        {
            
            repo.AddMarca(marca);
            return View("salvo");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View("Form", repo.GetMarca(id));
        }
        [HttpPost]
        public IActionResult Update(Marca marca)
        {
            repo.UpdateMarca(marca);
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            repo.RemoverMarca(id);
            return View("Update");
        }

    }
}
