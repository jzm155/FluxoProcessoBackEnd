using FluxoProcesso.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Dtos
{
    public class PessoaDto
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataAdmissao { get; set; }

        public DateTime? DataDemissao { get; set; }

        public CargoEnum Cargo { get; set; }

        public NivelEnum Nivel { get; set; }
    }
}
