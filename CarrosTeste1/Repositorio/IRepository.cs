using CarrosTeste1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosTeste1.Repositorio
{
    public interface IRepository
    {
        //Carros
        void AddCarro(Carro carro);
        void UpdateCarro(Carro carro);
        void RemoverCarro(int id);
        Carro GetCarro(int id);
        ICollection<Carro> GetCarros();

        //-----------------------------

        //Marcas

        void AddMarca(Marca marca);
        void UpdateMarca(Marca marca);
        void RemoverMarca(int id);
        Marca GetMarca(int id);
        ICollection<Marca> GetMarcas();

    }
}
