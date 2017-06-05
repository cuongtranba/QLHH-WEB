using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace QLHH.DAL
{
    public static class DALService
    {
        public static IServiceCollection AddDALDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<HongLienContext>((serviceProvider, options) =>
                    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("QLHH")).UseInternalServiceProvider(serviceProvider)
                );
            return services;
        }
    }
}
