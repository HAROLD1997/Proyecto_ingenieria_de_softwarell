using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IngSoftwarell.Models
{
    public class Cliente
    {
        
        public string apellido { get; set; }
        public string nombre { get; set; }
        [Key]
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool estado { get; set; }
    }
}
