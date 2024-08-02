using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class Notification
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime SentDate { get; set; }
        [Required]
        public string Type { get; set; } // email, SMS, push
    }
}
