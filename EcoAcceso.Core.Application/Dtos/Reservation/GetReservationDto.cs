using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Dtos.Reservation
{
    public class GetReservationDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProtectedAreaID { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
