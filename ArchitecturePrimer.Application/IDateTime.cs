using System;

namespace ArchitecturePrimer.Application
{
    public interface IDateTime
    {
        int CurrentYear { get; }
        DateTime Now { get; }
    }
}