using AutoMapper;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Dtos.IncidentReport;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Domain.Entities;


namespace EcoAccesso.Core.Application.Services
{
    public class IncidentReportService : GenericService<CreateIncidentReportDto,GetIncidentReportDto, IncidentReport>, IIncidentReportService
    {
        private readonly IIncidentReportRepository _incidentReportRepository;
        private readonly IMapper _mapper;

        public IncidentReportService(IIncidentReportRepository incidentReportRepository, IMapper mapper) : base(incidentReportRepository, mapper)
        {
            _incidentReportRepository = incidentReportRepository;
            _mapper = mapper;
        }
    }
}
