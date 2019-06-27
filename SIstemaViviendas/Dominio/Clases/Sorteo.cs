using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Models
{
    [Table ("Sorteo")]
    public class Sorteo
    {
        [Key]
        [ForeignKey("Vivienda")]
        public int id { get; set; } //id sorteo, el id de la vivienda es la fk de esta

        [Required(ErrorMessage = "Fecha requerida")]
        public DateTime fecha { get; set; } // fecha a realizar el sorteo

        [Required(ErrorMessage = "Hora requerida")]
        [StringLength(4, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 4)]
        public int hora { get; set; } // hora en la que se va a realizar el sorteo

        [Required(ErrorMessage = "Vivienda requerida")]
        public Vivienda vivienda { get; set; } // vivienda a sortear

        public List<Usuario> inscriptos { get; set; } //lista de usuarios inscriptos 

        public Usuario adjudicatario { get; set; } // usuario ganador
    }
}