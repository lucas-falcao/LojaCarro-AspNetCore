using CarrosTeste1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosTeste1.ViewModels
{
    public class CarrosViewModels
    {
        public Carro Carro { get; set; }
        public Marca Marca { get; set; }
        public ICollection<Carro> carros { get; set; }
        public ICollection<Marca> marcas { get; set; }
    }
}
