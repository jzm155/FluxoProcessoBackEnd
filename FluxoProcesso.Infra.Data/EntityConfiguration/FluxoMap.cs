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
    public class FluxoMap : IEntityTypeConfiguration<Fluxo>
    {
        public void Configure(EntityTypeBuilder<Fluxo> builder)
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Nome).HasColumnName("Nome");
            builder.Property(x => x.Periodo).HasColumnName("IdPeriodo");
            builder.Property(x => x.AnoReferente).HasColumnName("AnoReferente");

            builder.HasMany(x => x.Processos)
                .WithOne(x => x.Fluxo)
                .HasForeignKey(x => x.IdFluxo);
        }
    }
}
