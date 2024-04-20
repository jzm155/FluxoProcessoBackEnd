using FluxoProcesso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Infra.Data.EntityConfiguration
{
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.Tipo).HasColumnName("IdTipo");
            builder.Property(x => x.IdProcessoSuperior).HasColumnName("IdProcessoSuperior");
            builder.Property(x => x.ProcessoFinal).HasColumnName("ProcessoFinal");
            builder.Property(x => x.IdFluxo).HasColumnName("IdFluxo");

            builder.HasMany(x => x.AvaliacoesProcessos)
                .WithOne(x => x.Processo)
                .HasForeignKey(x => x.IdProcesso);
        }
    }
}
