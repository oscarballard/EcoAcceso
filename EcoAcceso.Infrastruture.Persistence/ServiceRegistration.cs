using EcoAcceso.Infrastruture.Persistence.Repositories;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Infrastruture.Persistence.Contexts;
using EcoAccesso.Infrastruture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Infrastruture.Persistence
{
    //Extension Method - Decorator
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                {
                    options.EnableSensitiveDataLogging();
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));
                });
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IProtectedAreaRepository, ProtectedAreaRepository>();
            services.AddTransient<IPermissionRequestRepository, PermissionRequestRepository>();
            services.AddTransient<IProtectedAreaRepository, ProtectedAreaRepository>();
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<INotificationRepository, NotificationRepository>();
            services.AddTransient<IVisitHistoryRepository, VisitHistoryRepository>();
            services.AddTransient<IMaintenanceEventRepository, MaintenanceEventRepository>();
            services.AddTransient<IIncidentReportRepository, IncidentReportRepository>();
            #endregion
        }
    }
}
