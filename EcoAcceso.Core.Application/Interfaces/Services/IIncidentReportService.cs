using EcoAcceso.Core.Application.Dtos.MaintenanceEvent;
using EcoAccesso.Core.Application.Dtos.IncidentReport;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IIncidentReportService : IGenericService<CreateIncidentReportDto, GetIncidentReportDto, IncidentReport>
    {
    }
}
