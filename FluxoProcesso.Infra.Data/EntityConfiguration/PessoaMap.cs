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
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Pessoa");

            builder.Property(x => x.Nome).HasColumnName("Nome");

            builder.Property(x => x.Cargo).HasColumnName("IdCargo");

            builder.Property(x => x.Nivel).HasColumnName("IdNivel");

            builder.Property(x => x.DataAdmissao).HasColumnName("DataAdmissao");

            builder.Property(x => x.DataDemissao).HasColumnName("DataDemissao");
        }
    }
}
