using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Reservation()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
    
}
