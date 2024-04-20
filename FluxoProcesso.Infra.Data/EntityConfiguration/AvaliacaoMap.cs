using FluxoProcesso.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Infra.Data.EntityConfiguration
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("Descricao");
            builder.Property(x => x.Situacao).HasColumnName("IdSituacao");
            builder.Property(x => x.IdPessoa).HasColumnName("IdPessoa");

            builder.HasMany(x => x.AvaliacoesProcessos)
                .WithOne(x => x.Avaliacao)
                .HasForeignKey(x => x.IdAvaliacao);
        }
    }
}
