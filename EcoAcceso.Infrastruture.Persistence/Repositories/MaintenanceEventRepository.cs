﻿using EcoAccesso.Core.Application.Interfaces.Repositories;
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
    public class MaintenanceEventRepository : GenericRepository<MaintenanceEvent>, IMaintenanceEventRepository
    {
        private readonly ApplicationContext _context;
        public MaintenanceEventRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}