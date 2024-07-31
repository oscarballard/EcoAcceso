using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.VisitHistory
{
    public class GetVisitHistoryDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProtectedAreaID { get; set; }
        public DateTime VisitDate { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}
