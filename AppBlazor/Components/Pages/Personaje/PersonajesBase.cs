using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AppBlazor.Data.Models;

namespace AppBlazor.Components
{
    public class PersonajesBase : ComponentBase
    {
        public List<Personaje> listaPersonajes {get; set;}

        protected override async Task OnInitializedAsync() {
            listaPersonajes 
        }
    }
}