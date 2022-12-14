using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Especie : Ingrediente
    {
        public enum Sabores { Salado, Dulce, Agridulce}
        public string LugarDeOrigen { get; set; }
        public Sabores Sabor { get; set; }
        public int Gramos { get; set; }
    }
}
