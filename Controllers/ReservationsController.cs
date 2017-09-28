using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using hotelGetReservation.Models;

namespace hotelGetReservation.Controllers
{
	[Route("api/[controller]")]
	public class ReservationsController : Controller
	{
		// GET api/reservations/foo
		[HttpGet("{id}")]
		public string Get(string id)
		{
            // Connect to database 
            var db = new ReservationsContext();

            // Run query to get this reservation
            var reservations = db.Reservations.Where(p => p.Id == id);

            // Return reservation as JSON
            if (reservations == null) {
                // TODO return error
            }
            return JsonConvert.SerializeObject(reservations);
		}
   	}
}
