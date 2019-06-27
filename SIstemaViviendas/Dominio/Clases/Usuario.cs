using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Cédula requerida")]
        [StringLength(9, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 7)]
        public int cedula { get; set; } //cedula usuario

        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 2)]
        public string nombre { get; set; } //nombre usuario

        [Required(ErrorMessage = "Apellido requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 2)]
        public string apellido { get; set; } //apellido usuario

        [Required(ErrorMessage = "Email requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; } //email usuario

        [Required]
        public string pass { get; set; } //pass usuario

        public bool esAdjudicatario { get; set; } // si ya gano un sorteo

        public bool esJefe { get; set; } // si es 

        [Required(ErrorMessage = "Año de la vivienda requerido")]
        [Range(fechaNac.AddYears(18), DateTime.Today, ErrorMessage = "Año debe ser mayor a 1990")]
        public DateTime fechaNac { get; set; } //fecha de nacimiento, mayor de 18

        public virtual ICollection<Sorteo> sorteos { get; set; } // coleccion de sorteos del usuario


        // metodo si es jefe
        //metodo adjudicatario
        //metodo tostring?

    }
}