using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dominio.Models
{
    public abstract class Vivienda 
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; } //id vivienda

        [Required(ErrorMessage = "Dirección de la vivienda requerida")]
        [StringLength(50, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public String estado { get; set; } //estado de la vivienda, puede ser habilitada, inhabilitada, recibida o sorteada

        [Required(ErrorMessage = "Calle de la vivienda requerida")]
        [StringLength(50, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string calle { get; set; } //calle de la vivienda

        [Required(ErrorMessage = "Calle de la vivienda requerida")]
        [Range(1, 9999, ErrorMessage = "El numero de puerta debe ser mayor a 0 y menor a 10000")]
        public int numPuerta { get; set; } // numero de puerta de la vivienda

        [ForeignKey "Barrio"] 
        public int barrioId { get; set; } // id barrio de la vivienda
        public Barrio barrio { get; set; } //barrio

        [Required(ErrorMessage = "Descripción de la vivienda requerida")]
        [StringLength(255, ErrorMessage = "La {0} debe tener al menos {2} caracteres.", MinimumLength = 3)]
        public string descripcion { get; set; } // desc de la vivienda

        [Required(ErrorMessage = "Cantidad de baños de la vivienda requerida")]
        [Range(1, Int32.MaxValue, ErrorMessage = "La cantidad de baños debe ser mayor a 0")]
        public int cantBan { get; set; } // cantidad de banios de la vivienda

        [Required(ErrorMessage = "Cantidad de dormitorios de la vivienda requerida")]
        [Range(1, Int32.MaxValue, ErrorMessage = "La cantidad de dormitorios debe ser mayor a 0")]
        public int cantDorm { get; set; }  // cantidad de dormitorios de la vivienda

        [Required(ErrorMessage = "Metraje de la vivienda requerido")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Metraje debe ser mayor a 0")]
        public int metraje { get; set; } //metraje de la vivienda

        [Required(ErrorMessage = "Año de la vivienda requerido")]
        [Range(1990, DateTime.Now.Year, ErrorMessage = "Año debe ser mayor a 1990")]
        public int anioViv { get; set; }
        
        [Required(ErrorMessage = "Precio de la vivienda requerido")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Precio debe ser mayor a 0")]
        public int porMetro { get; set; } //precio por metro de la vivienda

        public virtual Sorteo sorteo { get; set; }

        // metodo de validacion
        // sobrecarga de tostring
        //contribucion?
        //devolver tipo
    }
}