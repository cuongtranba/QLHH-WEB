using Microsoft.Extensions.DependencyInjection;
using QLHH.DAL;
namespace QLHH.BUS
{
    public static class BUSService
    {
        public static IServiceCollection AddBUSServiceDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDALDependencies(connectionString);
            return services;
        }
    }
}
