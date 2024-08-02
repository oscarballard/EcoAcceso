using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Dtos.IncidentReport
{
    public class GetIncidentReportDto
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [ForeignKey("PermissionRequest")]
        public int ProtectedAreaID { get; set; }
        public PermissionRequest ProtectedArea { get; set; }
        public DateTime ReportDate { get; set; }
        public string IncidentDescription { get; set; }
        public string ReportStatus { get; set; } // open, in progress, closed
    }
}
