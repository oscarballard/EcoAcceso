using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using Microsoft.AspNetCore.Mvc;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateProtectedAreaDto dto)
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(CreateProtectedAreaDto dto)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(CreateProtectedAreaDto dto)
        {
            return Ok();
        }
        [HttpPatch]
        public async Task<IActionResult> Patch(CreateProtectedAreaDto dto)
        {
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(CreateProtectedAreaDto dto)
        {
            return Ok();
        }
    }
}
