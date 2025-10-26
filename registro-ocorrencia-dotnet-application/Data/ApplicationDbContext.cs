using Microsoft.EntityFrameworkCore;
using RegistroOcorrencias.Models;

namespace RegistroOcorrencias.Data  
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<Noticiante> Noticiantes { get; set; }
        public DbSet<AgenteResponsavel> AgentesResponsaveis { get; set; }
        public DbSet<Delegacia> Delegacias { get; set; }
        public DbSet<Terceiros> Terceiros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Ocorrencia>().ToTable("OCORRENCIA");
            modelBuilder.Entity<Ocorrencia>()
                .Property(o => o.StatusConcluido)
                .HasConversion<int>();

            modelBuilder.Entity<Noticiante>().ToTable("NOTICIANTE");
            modelBuilder.Entity<AgenteResponsavel>().ToTable("AGENTE_RESPONSAVEL");
            modelBuilder.Entity<Delegacia>().ToTable("DELEGACIA");
            modelBuilder.Entity<Terceiros>().ToTable("TERCEIROS");
        }
    }
}