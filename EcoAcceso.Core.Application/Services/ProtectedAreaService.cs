using AutoMapper;
using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Application.Interfaces.Repositories;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Services
{
    public class ProtectedAreaService : GenericService<CreateProtectedAreaDto, GetProtectedAreaDto, ProtectedArea>, IProtectedAreaService
    {
        private readonly IProtectedAreaRepository _protectedAreaRepository;
        private readonly IMapper _mapper;
        public ProtectedAreaService(IProtectedAreaRepository protectedAreaRepository, IMapper mapper) : base(protectedAreaRepository, mapper)
        {
            _protectedAreaRepository = protectedAreaRepository;
            _mapper = mapper;
        }
    }
}
