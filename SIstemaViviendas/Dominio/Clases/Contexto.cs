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

        public Contexto() : base("cadenaConexion")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // No pluraliza el nombre de las tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Barrio>()
                .HasMany<Vivienda>(b => b.Viviendas)
                .WithRequired(v => v.barrio)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Usuario>()
                .HasMany<Sorteo>(s => s.sorteos)
                .WithMany(p => p.inscriptos)
                .Map(r =>
                {
                    r.ToTable("Postulante_Sorteo");
                    r.MapLeftKey("PostulanteId");
                    r.MapRightKey("SorteoId");
                });

            modelBuilder.Entity<Sorteo>()
                .HasOptional<Usuario>(p => p.adjudicatario)
                .WithRequired(s => s.sorteo);
        }
    }
}
