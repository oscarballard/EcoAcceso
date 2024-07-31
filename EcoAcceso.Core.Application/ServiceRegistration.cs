using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.Core.Application.Services;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IProtectedAreaService, ProtectedAreaService>();
            services.AddTransient<IPermissionRequestService, PermissionRequestServices>();
            services.AddTransient<IProtectedAreaService, ProtectedAreaService>();
            services.AddTransient<IReservationService, ReservationServices>();
            services.AddTransient<INotificationService, NotificationServices>();
            services.AddTransient<IVisitHistoryService, VisitHistoryService>();
            services.AddTransient<IMaintenanceEventService, MaintenanceEventServices>();
            services.AddTransient<IIncidentReportService, IncidentReportService>();
            #endregion
        }
    }
}
