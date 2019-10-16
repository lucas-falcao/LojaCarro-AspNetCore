using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosTeste1.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CarrosTeste1.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {   
            return View();
        }
    }
}