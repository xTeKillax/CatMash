using Autofac;

namespace CatManagement.Infrastructure.DataAccess.InMemory
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Context>()
                .As<Context>()
                .SingleInstance();

            builder.RegisterAssemblyTypes(typeof(InfrastructureException).Assembly)
                .Where(type => type.Namespace.Contains("DataAccess.InMemory"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
