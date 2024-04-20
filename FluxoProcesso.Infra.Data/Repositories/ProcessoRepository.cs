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
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly AppDbContext _context;

        public ProcessoRepository(AppDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<Processo> GetProcessoAsync(long id)
        {
            return await _context.Processos.SingleAsync(p => p.Id == id);
        }

        public async Task<List<Processo>> GetProcessoByFluxoAsync(long idFluxo)
        {
            List<Processo> processos = await _context.Processos
               .Where(p => p.IdFluxo == idFluxo)
               .OrderBy(x => x.Id)
               .ToListAsync();

            return processos;
        }

        public async Task CreateProcessoAsync(Processo entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProcessoAsync(Processo entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProcessoAsync(long id)
        {
            Processo entity = await this.GetProcessoAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
