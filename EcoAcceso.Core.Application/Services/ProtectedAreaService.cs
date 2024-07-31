using AutoMapper;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Services
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
