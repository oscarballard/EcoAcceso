using AutoMapper;
using EcoAcceso.Core.Application.Dtos.PermissionRequest;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Application.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Services
{
    public class PermissionRequestServices : GenericService<CreatePermissionRequestDto, GetPermissionRequestDto, PermissionRequest>, IPermissionRequestService
    {
        private readonly IPermissionRequestRepository _PermissionRequesttRepository;
        private readonly IMapper _mapper;
        public PermissionRequestServices(IPermissionRequestRepository PermissionRequesttRepository, IMapper mapper) : base(PermissionRequesttRepository, mapper)
        {
            _PermissionRequesttRepository = PermissionRequesttRepository;
            _mapper = mapper;
        }
    }
}
