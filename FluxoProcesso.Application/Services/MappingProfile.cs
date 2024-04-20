using AutoMapper;
using FluxoProcesso.Application.Dtos;
using FluxoProcesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoProcesso.Application.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fluxo, FluxoDto>().ReverseMap();
            CreateMap<Processo, ProcessoDto>().ReverseMap();
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
        }
    }
}
