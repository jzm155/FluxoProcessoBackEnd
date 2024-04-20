using FluxoProcesso.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Contracts
{
    public interface IPessoaService
    {
        Task<PessoaDto> GetPessoaByIdAsync(int id);

        Task<List<PessoaDto>> GetAllPessoaAsync();

        Task CreatePessoaAsync(PessoaDto entity);

        Task UpdatePessoaAsync(PessoaDto entity);

        Task DeletePessoaAsync(int id);
    }
}
