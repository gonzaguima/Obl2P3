using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public Usuario sortear()
        {
            Random r = new Random();
            this.adjudicatario = ((List<Usuario>)inscriptos)[r.Next(inscriptos.Count)];
            this.adjudicatario.sorteo = this;
            this.adjudicatario.sorteos.Clear();
            return this.adjudicatario;
        }
    }
}