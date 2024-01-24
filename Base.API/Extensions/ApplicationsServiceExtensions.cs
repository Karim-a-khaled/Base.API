using Base.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Base.API.Extensions
{
    public static class ApplicationsServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddHttpContextAccessor();
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            //services.AddCors(options => options.AddPolicy(name: "NgOrigins", policy => {
            //    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            //}));

            return services;
        }
    }
}
