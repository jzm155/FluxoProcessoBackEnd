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
    public class AvaliacaoProcessoMap : IEntityTypeConfiguration<AvaliacaoProcesso>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoProcesso> builder)
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.IdAvaliacao).HasColumnName("IdAvaliacao");
            builder.Property(x => x.IdProcesso).HasColumnName("IdProcesso");
            builder.Property(x => x.Nota).HasColumnName("Nota");
        }
    }
}
