using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class ReservationsController : Controller
    {
        // GET
        public IActionResult Reservations()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
             return View();
        }

        [HttpPost]
        public static List<ReservationModel> getReservationsForUser(int id)
        {
            using (var db = new DatabaseContext())
            {
                List<ReservationModel> reservations = db.Rezervacija.Where(e => e.UserModelId == id).ToList();

                foreach (var reservation in reservations)
                {
                    reservation.EventModel = db.dogad.Where(e => e.EventModelId == reservation.EventModelId).First();
                    reservation.SeatModel = db.Sjedista.Where(e => e.SeatModelId == reservation.SeatModelId).First();

                }
                return reservations;
            }
        }
        
    }
}