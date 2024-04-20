using FluxoProcesso.Domain.Contracts;
using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Dtos
{
    public class FluxoDto
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public PeriodoEnum Periodo { get; set; }

        public int AnoReferente { get; set; }

        public List<ProcessoDto> Processos { get; set; }
    }
}
