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
    public class CarroController : Controller
    {
        private IRepository repo;

        public CarroController(IRepository repository)
        {
            repo = repository;
        }
        public IActionResult Index()
        {
            var carros = new CarrosViewModels();
            carros.carros = repo.GetCarros();
            return View(carros);
        }
        [HttpGet]
        public IActionResult Registro()
        {
            var marcas = new CarrosViewModels();
            marcas.marcas = repo.GetMarcas();         
            return View(marcas);
        }
        [HttpPost]
        public IActionResult Registro(Carro carro)
        {
            repo.AddCarro(carro);
            return View("salvo");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View("Form", repo.GetCarro(id));
        }
        [HttpPost]
        public IActionResult Update(Carro carro)
        {
            repo.UpdateCarro(carro);
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            repo.RemoverCarro(id);
            return View("update");
        }
    }
}
