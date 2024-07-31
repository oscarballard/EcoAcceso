using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        [ForeignKey("ProtectedArea")]
        public int ProtectedAreaID { get; set; }
        public ProtectedArea ProtectedArea { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public string ReservationStatus { get; set; } // confirmed, canceled
        [Required]
        public int NumberOfPeople { get; set; }
    }
}
