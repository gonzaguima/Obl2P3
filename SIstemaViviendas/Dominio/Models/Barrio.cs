using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Models
{
    public class Barrio
    {   
        public int id { get; set; }

        [Required (ErrorMessage = "Nombre del barrio requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string nombre { get; set; }

        [Required (ErrorMessage = "Descripción del barrio requerida")]
        [StringLength(255, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string descripcion { get; set; }
    }
}