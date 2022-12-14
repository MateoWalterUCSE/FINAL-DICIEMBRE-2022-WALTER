using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Liquido : Ingrediente
    {
        public enum TiposDeLiquidos { Aceite, Vinagre, Salsa}
        public int Minilitro { get; set; }
        public TiposDeLiquidos Tipo { get; set; }
    }
}
