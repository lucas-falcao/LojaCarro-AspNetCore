using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosTeste1.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Marca")]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        
        public string Nome { get; set; }
        public float Valor { get; set; }

    }
}
