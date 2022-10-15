using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IngSoftwarell.Models
{
    public class Cliente
    {
        
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        [Key]
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
    }
}
