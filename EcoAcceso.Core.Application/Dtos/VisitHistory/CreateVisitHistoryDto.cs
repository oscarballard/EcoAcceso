using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.VisitHistory
{
    public class CreateVisitHistoryDto
    {
        public int UserID { get; set; }
        public ICollection<CreateProtectedAreaDto> ProtectedArea { get; set; } = new HashSet<CreateProtectedAreaDto>();
        public DateTime VisitDate { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}
