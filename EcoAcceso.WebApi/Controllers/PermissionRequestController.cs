using EcoAcceso.Core.Application.Dtos.PermissionRequest;
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
    public class PermissionRequestController : BaseController<CreatePermissionRequestDto, GetPermissionRequestDto, PermissionRequest, IPermissionRequestService>
    {
        private readonly IPermissionRequestService _PermissionRequestRepository;
        public PermissionRequestController(IPermissionRequestService service, ILogger<PermissionRequestController> logger)
       : base(service, logger)
        {
        }
    }
}
