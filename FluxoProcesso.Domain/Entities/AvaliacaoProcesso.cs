using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Entities
{
    public class AvaliacaoProcesso
    {
        public long Id { get; set; }

        public long IdAvaliacao { get; set; }

        public Avaliacao Avaliacao { get; set; }

        public long IdProcesso { get; set; }

        public Processo Processo { get; set; }

        public int Nota { get; set; }

        public AvaliacaoProcesso(long idAvaliacao, long idProcesso, int nota) 
        {
            IdAvaliacao = idAvaliacao;
            IdProcesso = idProcesso;
            Nota = nota;
        }
    }
}
