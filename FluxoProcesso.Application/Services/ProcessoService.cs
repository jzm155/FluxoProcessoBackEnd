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
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;
        private readonly IFluxoRepository _fluxoRepository;
        private readonly IMapper _mapper;

        public ProcessoService(IProcessoRepository processoRepository, IFluxoRepository fluxoRepository, IMapper mapper)
        {
            _processoRepository = processoRepository;
            _fluxoRepository = fluxoRepository;
            _mapper = mapper;
        }

        public async Task<ProcessoDto> GetProcessoAsync(int id)
        {
            Processo processo = await _processoRepository.GetProcessoAsync(id);
            return _mapper.Map<ProcessoDto>(processo);
        }

        public async Task CreateProcessoAsync(ProcessoDto dto)
        {
            Processo processo = _mapper.Map<Processo>(dto);
            await _processoRepository.CreateProcessoAsync(processo);
        }

        public async Task UpdateProcessoAsync(ProcessoDto dto)
        {
            Processo processo = await _processoRepository.GetProcessoAsync(dto.Id);

            processo.Nome = dto.Nome;

            await _processoRepository.UpdateProcessoAsync(processo);
        }

        public async Task DeleteProcessoAsync(int id)
        {
            await _processoRepository.DeleteProcessoAsync(id);
        }
    }
}
