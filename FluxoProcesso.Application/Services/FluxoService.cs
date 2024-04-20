using AutoMapper;
using FluxoProcesso.Application.Contracts;
using FluxoProcesso.Application.Dtos;
using FluxoProcesso.Domain.ContractsRepository;
using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Services
{
    public class FluxoService : IFluxoService
    {
        private readonly IFluxoRepository _fluxoRepository;
        private readonly IMapper _mapper;

        public FluxoService(IFluxoRepository fluxoRepository, IMapper mapper)
        {
            _fluxoRepository = fluxoRepository;
            _mapper = mapper;
        }

        public async Task<List<FluxoDto>> GetAllFluxoAsync()
        {
            List<Fluxo> fluxos = await _fluxoRepository.GetAllFluxoAsync();
            return _mapper.Map<List<FluxoDto>>(fluxos);
        }

        public async Task<FluxoDto> GetFluxoByIdAsync(int id)
        {
            Fluxo fluxo = await _fluxoRepository.GetFluxoByIdAsync(id);
            return _mapper.Map<FluxoDto>(fluxo);
        }

        public async Task CreateFluxoAsync(FluxoDto dto)
        {
            Fluxo entity = _mapper.Map<Fluxo>(dto);
            await _fluxoRepository.CreateFluxoAsync(entity);
        }

        public async Task UpdateFluxoAsync(FluxoDto dto)
        {
            Fluxo entity = await _fluxoRepository.GetFluxoByIdAsync(dto.Id);

            entity.Nome = dto.Nome;

            await _fluxoRepository.UpdateFluxoAsync(entity);
        }

        public async Task DeleteFluxoAsync(int id)
        {
            await _fluxoRepository.DeleteFluxoAsync(id);
        }
    }
}
