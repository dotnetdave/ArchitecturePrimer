using Autofac;

namespace ArchitecturePrimer.Persistence
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FakeDbContext>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}