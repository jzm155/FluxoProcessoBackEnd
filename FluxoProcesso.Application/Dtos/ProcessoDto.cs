using FluxoProcesso.Domain.Contracts;
using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Dtos
{
    public class ProcessoDto
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public TipoProcessoEnum Tipo { get; set; }

        public long? IdProcessoSuperior { get; set; }

        public bool ProcessoFinal { get; set; }

        public long IdFluxo { get; set; }

        public FluxoDto Fluxo { get; set; }

        public List<ProcessoDto> Processos { get; set; }

        public List<AvaliacaoProcessoDto> AvaliacoesProcessos { get; set; }
    }
}
