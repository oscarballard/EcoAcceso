using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Dtos
{
    public class GetIncidentReport
    {
        public Guid ID { get; set; }
        public int UserID { get; set; }
        public int ProtectedAreaID { get; set; }
        public DateTime ReportDate { get; set; }
        public string IncidentDescription { get; set; }
        //public ReportStatus Status { get; set; }
    }
}
