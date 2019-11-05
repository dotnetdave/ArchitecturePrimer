using System;
using ArchitecturePrimer.Application;

namespace ArchitecturePrimer.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public int CurrentYear => DateTime.Now.Year;
        public DateTime Now => DateTime.Now;
    }
}