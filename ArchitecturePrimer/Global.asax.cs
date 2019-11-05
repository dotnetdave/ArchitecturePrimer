using ArchitecturePrimer.Application.Home.Queries;
using ArchitecturePrimer.Application.Mapping;
using ArchitecturePrimer.Persistence;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ArchitecturePrimer.Application.Pipeline;
using ArchitecturePrimer.Infrastructure;
using MediatR;
using NLogInjector;

namespace ArchitecturePrimer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureDependencyResolver();
        }

        private void ConfigureDependencies(ContainerBuilder builder)
        {
            //Setup NLog
            builder.RegisterModule<NLogModule>();

            //Register framework for mediator pattern MediatR
            builder.RegisterGeneric(typeof(RequestPerformanceBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(LoggingBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
            builder.AddMediatR(typeof(GetHomeQuery).Assembly);

            //Register object mapping framework AutoMapper
            builder.AddAutoMapper(typeof(MappingProfile).Assembly, typeof(InfrastructureMappingProfile).Assembly);

            //Register controllers with Autofac
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //Register assembly modules with Autofac
            builder.RegisterModule<PersistenceModule>();
            builder.RegisterModule<InfrastructureModule>();
        }

        private void ConfigureDependencyResolver()
        {
            // Setup the container
            var builder = new ContainerBuilder();
            ConfigureDependencies(builder);
            var container = builder.Build();

            //Resolver for Autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //Web Api Resolver for Autofac
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}