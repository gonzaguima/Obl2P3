using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Models
{
    public class Sorteo
    {
        [Required(ErrorMessage = "Fecha requerida")]
        public DateTime fecha { get; set; }
        [Required(ErrorMessage = "Hora requerida")]
        [StringLength(4, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 4)]
        public int hora { get; set; }
        [Required(ErrorMessage = "Vivienda requerida")]
        public Vivienda vivienda { get; set; }
        public List<Usuario> inscriptos { get; set; }
        public Usuario adjudicatario { get; set; }
    }
}