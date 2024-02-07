namespace FrostArc.Web.Infrastructire.Extensions
{
    using System.Reflection;

    using Microsoft.Extensions.DependencyInjection;

    public static class WebApplicationBuilderExtensions
    {
        public static void RegisterApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly serviceAssembly = serviceType.Assembly;

            Type[] implementationTypes = serviceAssembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implType in implementationTypes)
            {
                Type? interfaceType = implType.GetInterface($"I{implType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No interface found for the service with name {implType.Name}");
                }

                services.AddScoped(interfaceType, implType);
            }
        }
    }
}
