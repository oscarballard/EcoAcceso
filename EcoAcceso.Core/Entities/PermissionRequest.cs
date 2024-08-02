using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoAcceso.Core.Domain.Enums;

namespace EcoAccesso.Core.Domain.Entities
{
    public class PermissionRequest
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        [Required]
        public PermissionRequestStatus Status { get; set; } // pending, under review, approved, rejected
        public string Comments { get; set; }
        public string Attachments { get; set; } // e.g., ID card
    }
}
