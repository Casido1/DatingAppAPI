using DatingAppAPI.Data;
using DatingAppAPI.Data.Repositories.Impementation;
using DatingAppAPI.Data.Repositories.Interfaces;
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
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
