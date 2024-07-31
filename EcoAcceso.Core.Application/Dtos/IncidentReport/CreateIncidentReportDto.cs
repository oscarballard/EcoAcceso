using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Dtos.IncidentReport
{
    public class CreateIncidentReportDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProtectedAreaID { get; set; }
        public DateTime ReportDate { get; set; }
        public string IncidentDescription { get; set; }
        public string ReportStatus { get; set; } // open, in progress, closed
    }
}
