using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AppBlazor.Data.Models;

namespace AppBlazor.Components
{
    public class PersonajesBase : ComponentBase
    {
        public List<PersonajeBase> listaPersonajes {get; set;}

        protected override async Task OnInitializedAsync() {
            listaPersonajes = new List<PersonajeBase>();
        }

        protected void Accion(int _id, string _nombre, int _nivel, string _tipo, double _salud, 
        double _energia, double _fuerza, double _inteligencia, double _agilidad, double _defensa, 
        double _resistencia, double _experiencia, string _inventario) {
            if (_id != 0)
            {
                
            }
            int dato = listaPersonajes.Count + 1;
            personaje.Id = dato;
            listaPersonajes.Add(personaje)
        }
    }
}