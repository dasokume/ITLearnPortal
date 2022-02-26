using IT.Learn.Portal.Application.Interfaces.Persistence;
using IT.Learn.Portal.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IT.Learn.Portal.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // TODO
            //services.AddDbContext<ITLearnPortalDbContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("ITLearnPortalConnectionString")));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IEventRepository, EventRepository>();

            return services;
        }
    }
}