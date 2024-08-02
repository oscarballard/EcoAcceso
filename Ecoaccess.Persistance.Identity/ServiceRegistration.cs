using EcoAcceso.Core.Application.Interfaces.Services;
using Ecoaccess.Persistance.Identity.Contexts;
using Ecoaccess.Persistance.Identity.Entities;
using Ecoaccess.Persistance.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecoaccess.Persistance.Identity
{
    //Extension Method - Decorator
    public static class ServiceRegistration2
    {
        public static void AddIdentityInfrastructure2(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IdentityContext>(options => options.UseInMemoryDatabase("IdentityDb"));
            }
            else
            {
                services.AddDbContext<IdentityContext>(options =>
                {
                    options.EnableSensitiveDataLogging();
                    options.UseSqlServer(configuration.GetConnectionString("IdentityConnection"),
                    m => m.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName));
                });
            }
            #endregion

            #region Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Users";
                options.AccessDeniedPath = "/Users/AccessDenied";
            });

            services.AddAuthentication();
            #endregion

            #region Services
            services.AddTransient<IAccountService, AccountService>();
            #endregion
        }
    }
}