using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosTeste1.Models;

namespace CarrosTeste1.Repositorio
{
    public class Repository : IRepository
    {
        private BancoContext db;

        public Repository(BancoContext bancoContext)
        {
            db = bancoContext;
        }
        public void AddCarro(Carro carro)
        {
            db.Carros.Add(carro);
            db.SaveChanges();
        }

        public void AddMarca(Marca marca)
        {
            db.Marcas.Add(marca);
            db.SaveChanges();
        }

        public Carro GetCarro(int id)
        {
            return db.Carros.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Carro> GetCarros()
        {
            return db.Carros.ToList();
        }

        public Marca GetMarca(int id)
        {
            return db.Marcas.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Marca> GetMarcas()
        {
            return db.Marcas.ToList();

        }

        public void RemoverCarro(int id)
        {
            db.Remove(GetCarro(id));
            db.SaveChanges();
        }

        public void RemoverMarca(int id)
        {
            db.Marcas.Remove(GetMarca(id));
            db.SaveChanges();
        }

        public void UpdateCarro(Carro carro)
        {
            var car = GetCarro(carro.Id);
            car.Nome = carro.Nome;
            car.Valor = carro.Valor;
    
            db.SaveChanges();
        }

        public void UpdateMarca(Marca marca)
        {
            var g = GetMarca(marca.Id);
            g.Descricao = marca.Descricao;
           
            db.SaveChanges();
        }
    }
}
