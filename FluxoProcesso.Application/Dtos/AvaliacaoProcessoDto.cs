using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Dtos
{
    public class AvaliacaoProcessoDto
    {
        public long Id { get; set; }

        public long IdAvaliacao { get; set; }

        public AvaliacaoDto Avaliacao { get; set; }

        public long IdProcesso { get; set; }

        public ProcessoDto Processo { get; set; }

        public int Nota { get; set; }
    }
}
