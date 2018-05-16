using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestApplicationHostel.Models
{
    public class Reservation
    {
        [Required]
        [StringLength (10)]
        public string ReservationCode { get; set; }
        [Required]
        public DateTime CreationDateOfReservation { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public int ID { get; set; }

        public int Commission { get; set; }
        public string Source { get; set; }
    }
}