using FluxoProcesso.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Entities
{
    public class Processo
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public TipoProcessoEnum Tipo { get; set; }

        public long? IdProcessoSuperior { get; set; }

        public bool ProcessoFinal { get; set; }

        public long IdFluxo { get; set; }

        public Fluxo Fluxo { get; set; }

        public List<Processo> Processos { get; set; }

        public List<AvaliacaoProcesso> AvaliacoesProcessos { get; set; }

        public Processo(string nome, TipoProcessoEnum tipo,  long? idProcessoSuperior, bool processoFinal, long idFluxo) 
        {
            Nome = nome;
            Tipo = tipo;
            IdProcessoSuperior = idProcessoSuperior;
            ProcessoFinal = processoFinal;
            IdFluxo = idFluxo;
        }
    }
}
