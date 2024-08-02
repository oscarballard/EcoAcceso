using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class IncidentReport
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [ForeignKey("ProtectedArea")]
        public int ProtectedAreaID { get; set; }
        public ProtectedArea ProtectedArea { get; set; }
        public DateTime ReportDate { get; set; }
        public string IncidentDescription { get; set; }
        public string ReportStatus { get; set; } // open, in progress, closed
    }
}
