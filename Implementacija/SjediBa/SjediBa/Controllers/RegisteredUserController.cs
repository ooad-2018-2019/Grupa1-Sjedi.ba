using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class RegisteredUserController : Controller
    {
        private readonly DatabaseContext _context;

        public RegisteredUserController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: RegisteredUser
        public async Task<IActionResult> Index()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            return View(await _context.Registrovani.ToListAsync());
        }

        // GET: RegisteredUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani
                .FirstOrDefaultAsync(m => m.UserModelId == id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }

            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Create
        public IActionResult Create()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            return View();
        }

        // POST: RegisteredUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserModelId,Name,Surname,Address,DateOfBirth,Username,password")] RegisteredUserModel registeredUserModel, string password2)
        {
            
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            if (ModelState.IsValid)
            {
                using (var db = new DatabaseContext())
                {
                    if(registeredUserModel.DateOfBirth.CompareTo(DateTime.Now) >= 0 || registeredUserModel.DateOfBirth.Year < 1900)
                        return View();
                    
                    if(password2 != registeredUserModel.password)
                        return View();
                    
                    RegisteredUserModel registered = db.Registrovani.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    UnregistredUserModel unregistred = db.Neregistrovani.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    OrganizerModel organizer = db.Oranizatori.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    LocalAdministratorModel local = db.Lokalni.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    MainAdministratorModel main = db.Glavni.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    if (!(registered == null && unregistred == null && organizer == null && local == null && main == null))
                        return View();
                    
                    _context.Add(registeredUserModel);
                    await _context.SaveChangesAsync();
                    HttpContext.Session.SetString("role", "Registred");
                    HttpContext.Session.SetInt32("id", registeredUserModel.UserModelId);
                    
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani.FindAsync(id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }
            return View(registeredUserModel);
        }

        // POST: RegisteredUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserModelId,Name,Surname,Address,DateOfBirth,Username,password")] RegisteredUserModel registeredUserModel, string password2)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            registeredUserModel.UserModelId = id;

            if (ModelState.IsValid)
            {
                using (var db = new DatabaseContext())
                {
                    if (registeredUserModel.DateOfBirth.CompareTo(DateTime.Now) >= 0 ||
                        registeredUserModel.DateOfBirth.Year < 1900)
                        return View();

                    if(!(password2 == null || password2.Length == 0) && (registeredUserModel.password == null || registeredUserModel.password.Length == 0))
                        return View();
                    
                    if((password2 == null || password2.Length == 0) && !(registeredUserModel.password == null || registeredUserModel.password.Length == 0))
                        return View();
                    
                    if (!(password2 == null || password2.Length == 0) && !(registeredUserModel.password == null || registeredUserModel.password.Length == 0) && password2 != registeredUserModel.password)
                        return View();
                    
                    

                    RegisteredUserModel currentRegistered = db.Registrovani.Where(e => e.UserModelId == HttpContext.Session.GetInt32("id")).FirstOrDefault();
                    
                    RegisteredUserModel registered = db.Registrovani.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    UnregistredUserModel unregistred = db.Neregistrovani.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    OrganizerModel organizer = db.Oranizatori.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    LocalAdministratorModel local = db.Lokalni.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    MainAdministratorModel main = db.Glavni.Where(e => e.Username == registeredUserModel.Username).FirstOrDefault();

                    if (!(registered == null && unregistred == null && organizer == null && local == null && main == null) && currentRegistered.Username != registeredUserModel.Username)
                        return View();

                    if (registeredUserModel.password == null || registeredUserModel.password.Length == 0)
                        registeredUserModel.password = currentRegistered.password;
                }


                try
                {
                    _context.Update(registeredUserModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisteredUserModelExists(registeredUserModel.UserModelId))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction("Index", "Home");
            }
            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani
                .FirstOrDefaultAsync(m => m.UserModelId == id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }

            return View(registeredUserModel);
        }

        // POST: RegisteredUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            var registeredUserModel = await _context.Registrovani.FindAsync(id);
            _context.Registrovani.Remove(registeredUserModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisteredUserModelExists(int id)
        {
            return _context.Registrovani.Any(e => e.UserModelId == id);
        }
    }
}
