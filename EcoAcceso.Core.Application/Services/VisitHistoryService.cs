using AutoMapper;
using EcoAcceso.Core.Application.Dtos.VisitHistory;
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
    public class VisitHistoryService : GenericService<CreateVisitHistoryDto, GetVisitHistoryDto, VisitHistory>, IVisitHistoryService
    {
        private readonly IVisitHistoryRepository _VisitHistoryRepository;
        private readonly IMapper _mapper;
        public VisitHistoryService(IVisitHistoryRepository VisitHistoryRepository, IMapper mapper) : base(VisitHistoryRepository, mapper)
        {
            _VisitHistoryRepository = VisitHistoryRepository;
            _mapper = mapper;
        }
    }
}
