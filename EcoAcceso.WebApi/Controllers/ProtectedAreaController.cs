using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcoAcceso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedAreaController : ControllerBase
    {
        private readonly IProtectedAreaService _protectedAreaService;
        public ProtectedAreaController(IProtectedAreaService protectedAreaService) 
        {
            _protectedAreaService = protectedAreaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProtectedAreaDto dto)
        {
            return Ok(await _protectedAreaService.Add(dto));
        }
    }
}
