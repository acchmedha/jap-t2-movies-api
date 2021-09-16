using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Services.AuthService;
using JAP_Task_1_MoviesApi.Services.MovieService;
using JAP_Task_1_MoviesApi.Services.RatingService;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace JAP_Task_1_MoviesApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IMovieService, MovieRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

    }
}


