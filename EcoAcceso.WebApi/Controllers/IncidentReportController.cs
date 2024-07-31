using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.WebApi.Controllers;
using EcoAccesso.Core.Application.Dtos.IncidentReport;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Application.Services;
using EcoAccesso.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentReportController : BaseController<CreateIncidentReportDto, GetIncidentReportDto, IncidentReport, IIncidentReportService>
    {
        private readonly IIncidentReportRepository _incidentReportRepository;
        public IncidentReportController(IIncidentReportService service, ILogger<IncidentReportController> logger)
       : base(service, logger)
        {
        }
    }
}
