using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comun : Usuario
    {
        public Comun(int Codigo, Paises Pais, string Nombre, string Contraseña, bool CargarloComoVip)
            :base (Codigo, Pais, Nombre, Contraseña, CargarloComoVip)
        {
        }
    }
}
