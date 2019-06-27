using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dominio.Models
{
    [Table("Usada")]
    public class Usada : Vivienda
    {
        //prop contribucion si lo ponemos en la base
        //tostring base + monto contribucion
        //tipo return "viviendaUsada"
        //contribucion return monto
    }
}