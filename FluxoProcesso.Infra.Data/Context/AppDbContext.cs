using FluxoProcesso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Fluxo> Fluxos { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<AvaliacaoProcesso> AvaliacoesProcessos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
