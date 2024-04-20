using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.ContractsRepository
{
    public interface IFluxoRepository
    {
        Task<Fluxo> GetFluxoByIdAsync(long id);

        Task<List<Fluxo>> GetAllFluxoAsync();

        Task CreateFluxoAsync(Fluxo entity);

        Task UpdateFluxoAsync(Fluxo entity);

        Task DeleteFluxoAsync(long id);
    }
}
