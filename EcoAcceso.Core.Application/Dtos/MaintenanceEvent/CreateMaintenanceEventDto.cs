using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.MaintenanceEvent
{
    public class CreateMaintenanceEventDto
    {
        public ICollection<CreateProtectedAreaDto> ProtectedArea { get; set; } = new HashSet<CreateProtectedAreaDto>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
