using System.Collections.Generic;

namespace APIControllerslaraGecis.Models
{
    public interface IRepository
    {
        IEnumerable<Reservation> Reservations { get; }
        Reservation this[int id] { get; }
        Reservation AddReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
