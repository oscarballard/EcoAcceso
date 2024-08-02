using AutoMapper;
using EcoAcceso.Core.Application.Dtos.MaintenanceEvent;
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
    public class MaintenanceEventServices : GenericService<CreateMaintenanceEventDto, GetMaintenanceEventDto, MaintenanceEvent>, IMaintenanceEventService
    {
        private readonly IMaintenanceEventRepository _maintenanceEventRepository;
        private readonly IMapper _mapper;
        public MaintenanceEventServices(IMaintenanceEventRepository maintenanceEventRepository, IMapper mapper) : base(maintenanceEventRepository, mapper)
        {
            _maintenanceEventRepository = maintenanceEventRepository;
            _mapper = mapper;
        }
    }
}
