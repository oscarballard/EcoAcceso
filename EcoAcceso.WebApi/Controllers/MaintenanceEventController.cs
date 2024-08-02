using EcoAcceso.Core.Application.Dtos.MaintenanceEvent;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.WebApi.Controllers;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceEventController : BaseController<CreateMaintenanceEventDto, GetMaintenanceEventDto, MaintenanceEvent, IMaintenanceEventService>
    {
        private readonly IMaintenanceEventRepository _MaintenanceEventRepository;
        public MaintenanceEventController(IMaintenanceEventService service, ILogger<MaintenanceEventController> logger)
       : base(service, logger)
        {
        }
    }
}
