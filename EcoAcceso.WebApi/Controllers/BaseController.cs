using EcoAccesso.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcoAcceso.WebApi.Controllers
{
    public class BaseController<SaveViewModel, ViewModel, Model, Service> : ControllerBase
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
        where Service : IGenericService<SaveViewModel, ViewModel, Model>
    {
        protected readonly Service _service;
        protected readonly ILogger<BaseController<SaveViewModel, ViewModel, Model, Service>> _logger;

        public BaseController(Service service, ILogger<BaseController<SaveViewModel, ViewModel, Model, Service>> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var result = await _service.GetByIdSaveViewModel(id);
                return HandleResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _service.GetAllViewModel();
                return HandleResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync([FromBody] SaveViewModel saveViewModel)
        {
            try
            {
                if (saveViewModel == null)
                {
                    return BadRequest(new { message = "Invalid entity." });
                }

                var createdEntity = await _service.Add(saveViewModel);

                return Ok(createdEntity);

                // Suponiendo que el createdEntity tiene una propiedad Id
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateAsync(int id, [FromBody] SaveViewModel saveViewModel)
        {
            try
            {
                if (saveViewModel == null)
                {
                    return BadRequest(new { message = "Invalid entity." });
                }

                await _service.Update(saveViewModel, id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var entity = await _service.GetByIdSaveViewModel(id);
                if (entity == null)
                {
                    return NotFound(new { message = "Entity not found." });
                }

                await _service.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        protected IActionResult HandleException(Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return StatusCode(500, new { message = "An error occurred while processing your request." });
        }

        protected IActionResult HandleResponse<T>(T result)
        {
            if (result == null)
            {
                return NotFound(new { message = "Resource not found." });
            }

            return Ok(result);
        }
    }
}
