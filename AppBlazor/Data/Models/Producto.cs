using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazor.Data.Models
{
    public class Producto
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "El título es necesario")]
        public string Titulo {get; set;}
        [Required(ErrorMessage = "La descripción es necesaria")]
        public string Descripcion {get; set;}
        [Required(ErrorMessage = "La imagen es necesaria")]
        public string Imagen {get; set;}
        [Required(ErrorMessage = "El precio es necesario")]
        public double Precio {get; set;}
    }
}