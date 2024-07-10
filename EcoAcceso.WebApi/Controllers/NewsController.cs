using EcoAcceso.Core.Application.Dtos.News;
using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcoAcceso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService) 
        {
            _newsService = newsService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateNewsDto dto)
        {
            return Ok(await _newsService.Add(dto));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> delete(int id)
        {
            await _newsService.Delete(id);
            return Ok();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> getNews()
        {
           
            return Ok(await _newsService.GetAllViewModel());
        }

        [HttpGet("GetByID")]
        public async Task<IActionResult> getNewsById(int id)
        {

            return Ok(await _newsService.GetByIdSaveViewModel(id));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> updateNews(GetNewsDto dto, int id)
        {
            dto.Id = id;
            await _newsService.Update(dto, id);
            return Ok();
        }
    }
}
