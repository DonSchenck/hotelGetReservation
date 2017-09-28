using System;
namespace hotelGetReservation.Models
{
    public class Reservations
    {
        public string Id { get; set; }
        public DateTime CheckIn { get; set; }
        public int NumberOfNights { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalCost {
            get {
            return NumberOfNights * Rate;
            }
        }
    }
}
