using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using SjediBa.Models;
using System.Linq;

namespace SjediBa.Controllers
{
    public class LoginController : Controller
    {

        //private DatabaseContext db;

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Test(string email, string password)
        {

            if (email == null || password == null || email.Length == 0 || password.Length == 0)
                return RedirectToAction("Login");

            using (var db = new DatabaseContext())
            {

               RegisteredUserModel r = db.Registrovani.Where(e => e.Username == email && e.password == password).FirstOrDefault();

                UnregistredUserModel ur = db.Neregistrovani.Where(e => e.Username == email && e.password == password).FirstOrDefault();

                OrganizerModel o = db.Oranizatori.Where(e => e.Username == email && e.password == password).FirstOrDefault();

                LocalAdministratorModel lol = db.Lokalni.Where(e => e.Username == email && e.Password == password).FirstOrDefault();

                MainAdministratorModel mom = db.Glavni.Where(e => e.Username == email && e.Password == password).FirstOrDefault();

                if (r == null && ur == null && o == null && lol == null && mom == null)
                    return RedirectToAction("Login");
               
                if(r!= null)
                {
                    HttpContext.Session.SetString("role", "Registred");
                    HttpContext.Session.SetInt32("id", r.UserModelId);
                }else if (o != null)
                {
                    HttpContext.Session.SetString("role", "Organizer");
                    HttpContext.Session.SetInt32("id", o.OrganizerModelId);
                }else if (lol != null)
                {
                    HttpContext.Session.SetString("role", "Local");
                    HttpContext.Session.SetInt32("id", lol.AdministratorModelId);
                } else if (mom != null)
                {
                    HttpContext.Session.SetString("role", "Registred");
                    HttpContext.Session.SetInt32("id", mom.AdministratorModelId);
                }

                ViewBag.Role = HttpContext.Session.GetString("role");
                /*if (r != null)
                    return View("../Reservation/Reservation");
                */
                return RedirectToAction("Index", "Home");


            }



           
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
