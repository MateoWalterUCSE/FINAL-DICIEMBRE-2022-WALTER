using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Vip : Usuario
    {
        public List<int> IngredientesFavoritos { get; set; }
        public List<int> RecetasFavoritas { get; set; }
        public List<int> UsuariosFavoritos { get; set; }
        public Vip(int Codigo, Paises Pais, string Nombre, string Contraseña, bool CargarloComoVip, List<int> IngredientesFavoritos, List<int> RecetasFavoritas, List<int> UsuariosFavoritos)
            : base(Codigo, Pais, Nombre, Contraseña, CargarloComoVip)
        {
            this.IngredientesFavoritos = IngredientesFavoritos;
            this.RecetasFavoritas = RecetasFavoritas;
            this.UsuariosFavoritos = UsuariosFavoritos;
        }
        public void AgregarRecetaFavorita(Receta Receta)
        {
            if (Cooknote.RecetasRegistradas.Contains(Receta))
            {
                this.RecetasFavoritas.Add(Receta.Codigo);
            }
        }
        public void AgregarUsuarioFavorito(Usuario Usuario)
        {
            this.UsuariosFavoritos.Add(Usuario.Codigo);
        }
    }
}
