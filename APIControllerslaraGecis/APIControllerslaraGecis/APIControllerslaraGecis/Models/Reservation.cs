namespace APIControllerslaraGecis.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string GuestName { get; set; }
        public string Email { get; set; }
        public int NumberOfGuests { get; set; }
    }
}
