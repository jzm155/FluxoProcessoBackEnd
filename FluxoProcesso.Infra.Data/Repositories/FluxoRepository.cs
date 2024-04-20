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
    public class FluxoRepository : IFluxoRepository
    {
        private readonly AppDbContext _context;

        public FluxoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fluxo>> GetAllFluxoAsync()
        {
            return await _context.Fluxos
                .Include(f => f.Processos)
                .OrderByDescending(f => f.Id)
                .ToListAsync();
        }

        public async Task<Fluxo> GetFluxoByIdAsync(long id)
        {
            return await _context.Fluxos
                .Include(f => f.Processos)
                .SingleAsync(f => f.Id == id);
        }

        public async Task CreateFluxoAsync(Fluxo entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFluxoAsync(Fluxo entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFluxoAsync(long id)
        {
            Fluxo entity = await this.GetFluxoByIdAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
