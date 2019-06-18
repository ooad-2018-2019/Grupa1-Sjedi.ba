using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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

            if (email.Length == null || password.Length == null || email.Length == 0 || password.Length == 0)
                return RedirectToAction("Login");

            using (var db = new DatabaseContext())
            {

               RegisteredUserModel r = db.Registrovani.Where(e => e.Name == email && e.password == password).FirstOrDefault();

                UnregistredUserModel ur = db.Neregistrovani.Where(e => e.Name == email && e.password == password).FirstOrDefault();

                OrganizerModel o = db.Oranizatori.Where(e => e.Name == email && e.password == password).FirstOrDefault();

                LocalAdministratorModel lol = db.Lokalni.Where(e => e.Name == email && e.Password == password).FirstOrDefault();

                MainAdministratorModel mom = db.Glavni.Where(e => e.Name == email && e.Password == password).FirstOrDefault();

                if (r == null && ur == null && o == null && lol == null && mom == null)
                    return RedirectToAction("Login");

                if (r != null)
                    return View("../Events/Events");

                return RedirectToAction("Login");


            }



           
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
