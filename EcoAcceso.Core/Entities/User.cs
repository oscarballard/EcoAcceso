using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string UserType { get; set; } // visitor, ranger, admin

        public ICollection<PermissionRequest> PermissionRequests { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<VisitHistory> VisitHistories { get; set; }
        public ICollection<IncidentReport> IncidentReports { get; set; }
        public ICollection<News> PublishedNews { get; set; }
    }
}
