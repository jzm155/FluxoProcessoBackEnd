using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.ContractsRepository
{
    public interface IProcessoRepository
    {
        Task<Processo> GetProcessoAsync(long id);

        Task<List<Processo>> GetProcessoByFluxoAsync(long idFluxo);

        Task CreateProcessoAsync(Processo entity);

        Task UpdateProcessoAsync(Processo entity);

        Task DeleteProcessoAsync(long id);
    }
}
