using AutoMapper;
using EcoAcceso.Core.Application.Dtos.Reservation;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Services
{
    public class ReservationServices : GenericService<CreateReservationDto, GetReservationDto, Reservation>, IReservationService
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;
        public ReservationServices(IReservationRepository ReservationRepository, IMapper mapper) : base(ReservationRepository, mapper)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
        }
    }
}
