using FluxoProcesso.Application.Contracts;
using FluxoProcesso.Application.Services;
using FluxoProcesso.Domain.ContractsRepository;
using FluxoProcesso.Infra.Data.Context;
using FluxoProcesso.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Infra.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IFluxoRepository, FluxoRepository>();
            services.AddScoped<IFluxoService, FluxoService>();
            services.AddScoped<IProcessoRepository, ProcessoRepository>();
            services.AddScoped<IProcessoService, ProcessoService>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
