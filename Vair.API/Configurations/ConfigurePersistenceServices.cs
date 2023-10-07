using Microsoft.EntityFrameworkCore;
using Vair.Persistence;

namespace Vair.API.Configurations
{
    public static class ConfigurePersistenceServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultDb"));
            });
            return services;
        }
    }
}
