using EcoAcceso.Core.Application.Interfaces.Repositories;
using EcoAcceso.Core.Domain.Entities;
using EcoAcceso.Infrastruture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Infrastruture.Persistence.Repositories
{
    public class ProtectedAreaRepository : GenericRepository<ProtectedArea>, IProtectedAreaRepository
    {
        private readonly ApplicationContext _context;
        public ProtectedAreaRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
