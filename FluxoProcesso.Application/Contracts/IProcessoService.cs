using FluxoProcesso.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Contracts
{
    public interface IProcessoService
    {
        Task<ProcessoDto> GetProcessoAsync(int id);

        //Task<RetornoProcessosDto> GetProcessoByFluxoAsync(int idFluxo);

        Task CreateProcessoAsync(ProcessoDto entity);

        Task UpdateProcessoAsync(ProcessoDto entity);

        Task DeleteProcessoAsync(int id);
    }
}
