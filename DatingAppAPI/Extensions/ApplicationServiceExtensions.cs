using DatingAppAPI.Data;
using DatingAppAPI.Services.Implementations;
using DatingAppAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DatingAppContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DatingAppDb"));
            });

            services.AddCors();

            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
