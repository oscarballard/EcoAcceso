using EcoAcceso.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.PermissionRequest
{
    public class GetPermissionRequestDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime RequestDate { get; set; }
        public PermissionRequestStatus Status { get; set; }
        public string Comments { get; set; }
        public List<string> AttachedDocuments { get; set; } // Assuming file paths or URLs
    }
}
