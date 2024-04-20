using FluxoProcesso.Domain.Contracts;
using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Dtos
{
    public class AvaliacaoDto
    {
        public long Id { get; set; }

        public string Descricao { get; set; }

        public SituacaoEnum Situacao { get; set; }

        public long IdPessoa { get; set; }

        public PessoaDto Pessoa { get; set; }

        public List<AvaliacaoProcessoDto> AvaliacoesProcessos { get; set; }
    }
}
