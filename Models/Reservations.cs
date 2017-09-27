using System;
namespace hotelGetReservation.Models
{
    public class Reservations
    {
        public string Id { get; set; }
        public DateTime CheckIn { get; set; }
        public int NumberOfNights { get; set; }
        public double Rate { get; set; }
        public double TotalCost {
            get {
            return NumberOfNights * Rate;
            }
        }
    }
}
