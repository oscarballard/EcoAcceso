using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Domain.Entities;
using EcoAccesso.Infrastruture.Persistence.Contexts;
using EcoAccesso.Infrastruture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Infrastruture.Persistence.Repositories
{
    internal class IncidentReportRepository : GenericRepository<IncidentReport>, IIncidentReportRepository
    {
        private readonly ApplicationContext _context;
        public IncidentReportRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
