using AutoMapper;
using caminhoes.Application.Commands;
using caminhoes.Domain.Entities;

namespace caminhoes.Infrastructure.AutoMapper
{
    public class CommandToDomainMappingProfile : Profile
    {
        public CommandToDomainMappingProfile()
        {
            CreateMap<Caminhao, CaminhaoCommand>()
            .ForMember(r => r.AggregateRoot, o => o.MapFrom(o =>  o.Id )).ReverseMap();
            
            CreateMap<Caminhao, CaminhaoCommand>()
            .ForMember(r => r.AggregateRoot, o => o.MapFrom(o => o.Id));
            
            CreateMap<CaminhaoCommand, Caminhao>()
                .ConstructUsing(p => new Caminhao() { Modelo=p.Modelo});
            CreateMap<CaminhaoCommand, Caminhao>()
               .ConstructUsing(p => new Caminhao() { AnoFabricacao = p.AnoFabricacao });
            CreateMap<CaminhaoCommand, Caminhao>()
                           .ConstructUsing(p => new Caminhao() { AnoModelo = p.AnoModelo });


        }
    }
}
