using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cooknote
    {
        public static List<Receta> RecetasRegistradas = new List<Receta>();
        public static List<Ingrediente> IngredientesRegistrados = new List<Ingrediente>();
        public static List<Usuario> UsuariosRegistrados = new List<Usuario>();
        public List<Receta> BuscarTexto(string Nombre, string Contraseña, string Texto)
        {
            if (Usuario.ContraseñaValida(Nombre, Contraseña) == true)
            {
                List<Receta> RecetasFiltradas = RecetasRegistradas.Where(x => x.Nombre.Contains(Texto) || (x.Ingredientes.Exists(y => y.Nombre.Contains(Texto))) == true).ToList();
                Usuario Usuario = UsuariosRegistrados.Find(x => x.Nombre == Nombre);
                if (Usuario is Vip)
                {
                    Vip vip = (Vip)Usuario;
                    foreach (Receta Receta in RecetasFiltradas)
                    {
                        if (vip.RecetasFavoritas.Contains(Receta.Codigo))
                        {
                            int Indice = RecetasFiltradas.IndexOf(Receta);
                            RecetasFiltradas.Insert(0, Receta);
                        }
                    }
                }
                return RecetasFiltradas;
            }
            return null;
        }
        public List<string> BuscarIngredientesPorDescripcion(string Nombre, string Contraseña)
        {
            if (Usuario.ContraseñaValida(Nombre, Contraseña) == true)
            {
                List<string> DescripcionIngredientes = new List<string>();
                foreach(Ingrediente Ingrediente in IngredientesRegistrados)
                {
                    DescripcionIngredientes.Add(Ingrediente.Descripcion);
                }
                return DescripcionIngredientes;
            }
            return null;
        }
    }
}
