using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SjediBa.Models;

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
            ProxyModel proxyModel = new ProxyModel(email, password);
            Object result = proxyModel.Check();
            
            if (!(result is RegisteredUserModel) && !(result is UnregistredUserModel) && 
                !(result is LocalAdministratorModel) && !(result is MainAdministratorModel) && 
                !(result is OrganizerModel) && result == null)
                return RedirectToAction("Login");

            if (result is RegisteredUserModel)
            {
                HttpContext.Session.SetString("role", "Registred");
                HttpContext.Session.SetInt32("id", (result as RegisteredUserModel).UserModelId);
                return RedirectToAction("Index", "Home");
            }

            if (result is OrganizerModel)
            {
                HttpContext.Session.SetString("role", "Organizer");
                HttpContext.Session.SetInt32("id", (result as OrganizerModel).OrganizerModelId);
                return RedirectToAction("Index", "Home");
            }

            if (result is LocalAdministratorModel)
            {
                HttpContext.Session.SetString("role", "Local");
                HttpContext.Session.SetInt32("id", (result as LocalAdministratorModel).AdministratorModelId);
                return RedirectToAction("Index", "Home");
            }

            if (result is MainAdministratorModel)
            {
                HttpContext.Session.SetString("role", "Main");
                HttpContext.Session.SetInt32("id", (result as MainAdministratorModel).AdministratorModelId);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Login");
            
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
