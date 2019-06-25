using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Models
{
    public abstract class Vivienda
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Dirección de la vivienda requerida")]
        [StringLength(50, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public String estado { get; set; }
        public string direccion { get; set; }
        [Required(ErrorMessage = "Barrio requerido")]
        public Barrio barrio { get; set; }
        [Required(ErrorMessage = "Descripción de la vivienda requerida")]
        [StringLength(255, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string descripcion { get; set; }
        [Required(ErrorMessage = "Cantidad de dormitorios de la vivienda requerida")]
        [Range(1, Int32.MaxValue, ErrorMessage = "La cantidad de dormitorios debe ser mayor a 0")]
        public int cantDorm { get; set; }
        [Required(ErrorMessage = "Metraje de la vivienda requerido")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Metraje debe ser mayor a 0")]
        public int metraje { get; set; }
        [Required(ErrorMessage = "Precio por metro de la vivienda requerido")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Precio por metro debe ser mayor a 0")]
        public int porMetro { get; set; }
    }
}