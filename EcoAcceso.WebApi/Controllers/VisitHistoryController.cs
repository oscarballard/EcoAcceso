using EcoAcceso.Core.Application.Dtos.VisitHistory;
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
    public class VisitHistoryController : BaseController<CreateVisitHistoryDto, GetVisitHistoryDto, VisitHistory, IVisitHistoryService>
    {
        private readonly IVisitHistoryRepository _VisitHistoryRepository;
        public VisitHistoryController(IVisitHistoryService service, ILogger<VisitHistoryController> logger)
       : base(service, logger)
        {
        }
    }
}
