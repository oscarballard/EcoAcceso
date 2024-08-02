using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class MaintenanceEvent
    {
        public int ID { get; set; }
        [ForeignKey("PermissionRequest")]
        public int ProtectedAreaID { get; set; }
        public PermissionRequest ProtectedArea { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
