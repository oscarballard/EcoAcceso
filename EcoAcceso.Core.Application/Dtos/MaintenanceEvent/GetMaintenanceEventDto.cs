using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.MaintenanceEvent
{
    public class GetMaintenanceEventDto
    {
        public int ID { get; set; }
        public int ProtectedAreaID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
