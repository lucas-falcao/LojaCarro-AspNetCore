using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosTeste1.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Carro> Carros { get; set; }

    }
}
