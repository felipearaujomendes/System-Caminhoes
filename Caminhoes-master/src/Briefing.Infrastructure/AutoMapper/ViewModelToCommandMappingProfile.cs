using AutoMapper;
using caminhoes.Application.Commands;
using caminhoes.Application.ViewModels;

namespace caminhoes.Infrastructure.AutoMapper
{
    public class ViewModelToCommandMappingProfile : Profile
    {
        public ViewModelToCommandMappingProfile()
        {
            CreateMap<CaminhaoViewModel, CaminhaoCommand>()
            .ForMember(r => r.AggregateRoot, o => o.MapFrom(o => o.Id));
        }
    }
}
