using EcoAcceso.Core.Application.Dtos.MaintenanceEvent;
using EcoAcceso.Core.Application.Dtos.Notifications;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IMaintenanceEventService : IGenericService<CreateMaintenanceEventDto, GetMaintenanceEventDto, MaintenanceEvent>
    {
    }
}
