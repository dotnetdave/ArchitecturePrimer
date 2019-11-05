using ArchitecturePrimer.Infrastructure;
using Autofac;

namespace ArchitecturePrimer.Persistence
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MachineDateTime>()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterType<TwitterFetcher>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}