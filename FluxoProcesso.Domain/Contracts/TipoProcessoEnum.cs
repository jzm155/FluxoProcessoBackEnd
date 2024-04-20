using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Contracts
{
    public enum TipoProcessoEnum : long
    {
        Comprometimento = -5,
        Comunicacao = -4,
        Proatividade = -3,
        Qualidade = -2,
        Quantidade = -1
    }
}
