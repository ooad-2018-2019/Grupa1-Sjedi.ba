using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SjediBa.Models;

namespace dotnettest.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
