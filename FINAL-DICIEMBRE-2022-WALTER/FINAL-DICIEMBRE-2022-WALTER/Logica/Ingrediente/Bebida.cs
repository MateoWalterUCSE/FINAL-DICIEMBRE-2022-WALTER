using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Bebida : Ingrediente
    {
        public enum TiposDeBebidas { Vodka, Gin, Ton, Whisky, VinoBlanco, VinoTinto}
        public TiposDeBebidas TipoDeBebida { get; set; }
        public int Minilitros { get; set; }
    }
}
