using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Receta
    {
        public enum TiposReceta { Cocina, Postre, Coctel}
        public List<Ingrediente> Ingredientes { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public TiposReceta TipoReceta { get; set; }
        public Receta(string NombreUsuario, string Contraseña, List<Ingrediente> Ingredientes, string Nombre, string Autor, int Codigo, DateTime FechaEliminacion, TiposReceta TipoReceta)
        {
            if (Usuario.ContraseñaValida(NombreUsuario, Contraseña) == true)
            {
                this.Ingredientes = Ingredientes;
                this.Nombre = Nombre;
                this.Autor = Autor;
                this.Codigo = Codigo;
                this.FechaEliminacion = FechaEliminacion;
                this.TipoReceta = TipoReceta;
            }
        }
        public string Mensaje(string Nombre, string Contraseña)
        {
            if (Usuario.ContraseñaValida(Nombre, Contraseña) == true)
            {
                switch (this.TipoReceta)
                {
                    case TiposReceta.Coctel:
                        string Mensaje = this.Nombre + " - " + this.Autor;
                        foreach (Ingrediente Ingrediente in this.Ingredientes)
                        {
                            Mensaje += " - " + Ingrediente.Nombre;
                        }
                        return Mensaje;
                    case TiposReceta.Postre:
                        return this.Nombre + " - " + this.Autor;
                    default:
                        return this.Nombre + " - " + this.Autor + " - " + this.Ingredientes[0] + " - " + this.Ingredientes[1] + " - " + this.Ingredientes[2];
                }
            }
            else
            {
                return null;
            }
        }
    }
}
