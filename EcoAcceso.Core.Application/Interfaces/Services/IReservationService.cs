using EcoAcceso.Core.Application.Dtos.Reservation;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IReservationService : IGenericService<CreateReservationDto, GetReservationDto, Reservation>
    {
    }
}
