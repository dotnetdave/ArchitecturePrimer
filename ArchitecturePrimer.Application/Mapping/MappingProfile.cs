using System;
using ArchitecturePrimer.Application.ViewModels;
using ArchitecturePrimer.Application.ViewModels.Home;
using ArchitecturePrimer.Domain;
using AutoMapper;

namespace ArchitecturePrimer.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DateTime, string>().ConvertUsing<DateTimeStringTypeMapper>();
            CreateMap<HomeModel, HomeViewModel>();
            CreateMap<HomeFeatureModel, HomeFeatureViewModel>();
        }
    }
}