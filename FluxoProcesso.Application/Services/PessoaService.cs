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
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaService(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public async Task<PessoaDto> GetPessoaByIdAsync(int id)
        {
            Pessoa pessoa = await _pessoaRepository.GetPessoaByIdAsync(id);
            return _mapper.Map<PessoaDto>(pessoa);
        }

        public async Task CreatePessoaAsync(PessoaDto dto)
        {
            Pessoa pessoa = _mapper.Map<Pessoa>(dto);
            await _pessoaRepository.CreatePessoaAsync(pessoa);
        }

        public async Task UpdatePessoaAsync(PessoaDto dto)
        {
            Pessoa pessoa = await _pessoaRepository.GetPessoaByIdAsync(dto.Id);

            pessoa.Nome = dto.Nome;

            await _pessoaRepository.UpdatePessoaAsync(pessoa);
        }

        public async Task DeletePessoaAsync(int id)
        {
            await _pessoaRepository.DeletePessoaAsync(id);
        }

        public async Task<List<PessoaDto>> GetAllPessoaAsync()
        {
            List<Pessoa> pessoas = await _pessoaRepository.GetAllPessoaAsync();
            return _mapper.Map<List<PessoaDto>>(pessoas);
        }
    }
}
