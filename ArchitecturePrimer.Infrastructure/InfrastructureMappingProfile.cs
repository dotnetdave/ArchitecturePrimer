using ArchitecturePrimer.Application.ViewModels;
using ArchitecturePrimer.Domain;
using AutoMapper;

namespace ArchitecturePrimer.Infrastructure
{
    public class InfrastructureMappingProfile : Profile
    {
        public InfrastructureMappingProfile()
        {
            CreateMap<TweetModel, TweetViewModel>();
        }
    }
}