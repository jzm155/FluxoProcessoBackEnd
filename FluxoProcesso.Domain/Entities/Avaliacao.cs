using FluxoProcesso.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Entities
{
    public class Avaliacao
    {
        public long Id { get; set; }

        public string Descricao { get; set; }

        public SituacaoEnum Situacao { get; set; }

        public long IdPessoa { get; set; }

        public Pessoa Pessoa { get; set; }

        public List<AvaliacaoProcesso> AvaliacoesProcessos { get; set; }

        public Avaliacao(string descricao, SituacaoEnum situacao, long idPessoa)
        {
            Descricao = descricao;
            Situacao = situacao;
            IdPessoa = idPessoa;    
        }
    }
}
