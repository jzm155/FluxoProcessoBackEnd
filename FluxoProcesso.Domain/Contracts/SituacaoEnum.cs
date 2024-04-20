using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Contracts
{
    public enum SituacaoEnum : long
    {
        Cancelado = -3,
        Concluido = -2,
        EmAndamento = -1
    }
}
