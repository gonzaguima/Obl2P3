using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Models
{
    [Table("Barrio")]
    public class Barrio
    {   
        public int id { get; set; }
        [key]
        [Required (ErrorMessage = "Nombre del barrio requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string nombre { get; set; } //nombre del barrio

        [Required (ErrorMessage = "Descripción del barrio requerida")]
        [StringLength(255, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string descripcion { get; set; } // descripcion del barrio

        public virtual ICollection<Vivienda> Viviendas { get; set; } //coleccion de viviendas del barrio

        // sobrecarga de tostring con #

    }
}