using System;
using AutoMapper;
using Humanizer;

namespace ArchitecturePrimer.Application.Mapping
{
    public class DateTimeStringTypeMapper : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            return source.Humanize();
        }
    }
}