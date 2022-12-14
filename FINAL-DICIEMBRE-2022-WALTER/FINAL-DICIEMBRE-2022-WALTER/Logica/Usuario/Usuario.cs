using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario
    {
        public enum Paises { Argentina, Grecia, Hungria, Indonesia, Mexico, Rusia, España, Uruguay, Vietnam}
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public Paises Pais { get; set; }
        public Usuario(int Codigo, Paises Pais, string Nombre, string Contraseña, bool CargarloComoVip)
        {
            this.Codigo = Codigo;
            this.Pais = Pais;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
        }
        public Usuario(Usuario Usuario)
        {
            if (this is Vip)
            {
                Vip Vip = (Vip)this;
                Vip.AgregarUsuarioFavorito(Usuario);
            }
        }
        public Usuario(Receta Receta)
        {
            if (this is Vip)
            {
                Vip Vip = (Vip)this;
                Vip.AgregarRecetaFavorita(Receta);
            }           
        }
        public static bool ContraseñaValida(string Nombre, string Contraseña)
        {
            Usuario Usuario = Cooknote.UsuariosRegistrados.Find(x => x.Nombre == Nombre);
            if (Usuario.Contraseña == Contraseña)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
