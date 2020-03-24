using APIControllerslaraGecis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIControllerslaraGecis.Controllers
{
    [Route("api/[controller]")]
    public class ReservationApiController : Controller
    {
        private IRepository repository;

        public ReservationApiController(IRepository repo) => repository = repo;

        [HttpGet]
        public IEnumerable<Reservation> Get() => repository.Reservations;

        [HttpGet("{id}")]
        public Reservation Get(int id) => repository[id];

        [HttpPost]
        public Reservation Post([FromBody] Reservation res) => repository.AddReservation(new Reservation
        {
            GuestName = res.GuestName,
            Email = res.Email,
            NumberOfGuests = res.NumberOfGuests
        });


        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteReservation(id);
    }
}
