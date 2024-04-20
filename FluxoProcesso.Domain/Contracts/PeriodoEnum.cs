using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.Contracts
{
    public enum PeriodoEnum : long
    {
        Anual = -6,
        Semestral = -5,
        Quadrimenstral = -4,
        Trimestral = -3,
        Bimestral = -2,
        Mensal = -1
    }
}
