using FluxoProcesso.Domain.ContractsRepository;
using FluxoProcesso.Domain.Entities;
using FluxoProcesso.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Infra.Data.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;

        public PessoaRepository(AppDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<List<Pessoa>> GetAllPessoaAsync()
        {
            return await _context.Pessoas
                .OrderByDescending(f => f.Id)
                .ToListAsync();
        }

        public async Task<Pessoa> GetPessoaByIdAsync(long idPessoa)
        {
            return await _context.Pessoas
                .SingleAsync(f => f.Id == idPessoa);
        }

        public async Task CreatePessoaAsync(Pessoa entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePessoaAsync(Pessoa entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePessoaAsync(long idPessoa)
        {
            Pessoa entity = await this.GetPessoaByIdAsync(idPessoa);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
