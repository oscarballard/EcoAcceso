using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.WebApi.Controllers;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using EcoAcceso.Core.Application.Dtos.Reservation;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : BaseController<CreateReservationDto, GetReservationDto, Reservation, IReservationService>
    {
        private readonly IReservationRepository _ReservationRepository;
        public ReservationController(IReservationService service, ILogger<ReservationController> logger)
       : base(service, logger)
        {
        }
    }
}
