using EcoAcceso.WebApi.Controllers;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedAreaController : BaseController<CreateProtectedAreaDto, GetProtectedAreaDto, ProtectedArea, IProtectedAreaService>
    {
        private readonly IProtectedAreaService _ProtectedAreatRepository;
        public ProtectedAreaController(IProtectedAreaService service, ILogger<ProtectedAreaController> logger)
       : base(service, logger)
        {
            _ProtectedAreatRepository = service;
        }
    }
}
