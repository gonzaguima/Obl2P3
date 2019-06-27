using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dominio.Models
{
    class Contexto : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Barrio> barrios { get; set; }
        public DbSet<Vivienda> viviendas { get; set; }
        public DbSet<Sorteo> sorteos { get; set; }
    }
}
