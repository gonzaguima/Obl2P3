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
        public int cedula { get; set; }
        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 2)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Apellido requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener al menos {2} caracteres.", MinimumLength = 2)]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Email requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
        public string pass { get; set; }
        public bool esAdjudicatario { get; set; }
        public bool esJefe { get; set; }
    }
}