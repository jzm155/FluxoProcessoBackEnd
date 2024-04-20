using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Domain.ContractsRepository
{
    public interface IPessoaRepository
    {
        Task<List<Pessoa>> GetAllPessoaAsync();

        Task<Pessoa> GetPessoaByIdAsync(long idPessoa);

        Task CreatePessoaAsync(Pessoa entity);

        Task UpdatePessoaAsync(Pessoa entity);

        Task DeletePessoaAsync(long idPessoa);
    }
}
