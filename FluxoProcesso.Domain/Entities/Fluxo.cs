using FluxoProcesso.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Entities
{
    public class Fluxo
    {        
        public long Id { get; set; }

        public string Nome { get; set; }

        public PeriodoEnum Periodo { get; set; }

        public int AnoReferente { get; set; }

        public List<Processo> Processos { get; set; }

        public Fluxo()
        {
            Processos = new List<Processo>();
        }

        public Fluxo(string nome, PeriodoEnum periodo, int anoReferente)
        {
            Nome = nome;
            Periodo = periodo;
            AnoReferente = AnoReferente;
        }
    }
}
