using System.Collections.Generic;

namespace APIControllerslaraGecis.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation> items;

        public Repository()
        {
            items = new Dictionary<int, Reservation>();

            new List<Reservation>
            {
                new Reservation{GuestName = "Onur", Email = "onur@onurkayabasi.com", NumberOfGuests = 4},
                new Reservation{GuestName = "Aleyna", Email = "aleyna@onurkayabasi.com", NumberOfGuests = 5},
                new Reservation{GuestName = "Orcun", Email = "orcun@onurkayabasi.com", NumberOfGuests = 6}
            }.ForEach(r => AddReservation(r));
        }

        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.ReservationId == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; }
                reservation.ReservationId = key;
            }

            items[reservation.ReservationId] = reservation;

            return reservation;
        }

        public void DeleteReservation(int id) => items.Remove(id);
    }
}
