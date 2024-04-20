using FluxoProcesso.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Contracts
{
    public interface IFluxoService
    {
        Task<FluxoDto> GetFluxoByIdAsync(int id);

        Task<List<FluxoDto>> GetAllFluxoAsync();

        Task CreateFluxoAsync(FluxoDto entity);

        Task UpdateFluxoAsync(FluxoDto entity);

        Task DeleteFluxoAsync(int id);
    }
}
