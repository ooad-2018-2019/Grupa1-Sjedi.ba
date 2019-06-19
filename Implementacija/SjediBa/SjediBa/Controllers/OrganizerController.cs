using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class OrganizerController : Controller
    {
        private readonly DatabaseContext _context;

        public OrganizerController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Organizer
        public async Task<IActionResult> Index()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            return View(await _context.Oranizatori.ToListAsync());
        }

        // GET: Organizer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            if (id == null)
            {
                return NotFound();
            }

            var organizerModel = await _context.Oranizatori
                .FirstOrDefaultAsync(m => m.OrganizerModelId == id);
            if (organizerModel == null)
            {
                return NotFound();
            }

            return View(organizerModel);
        }

        // GET: Organizer/Create
        public IActionResult Create()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            return View();
        }

        // POST: Organizer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrganizerModelId,Name,Surname,Address,DateOfBirth,Username,password")] OrganizerModel organizerModel, string password2)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            if (ModelState.IsValid)
            {
                using (var db = new DatabaseContext())
                {
                    if(organizerModel.DateOfBirth.CompareTo(DateTime.Now) >= 0 || organizerModel.DateOfBirth.Year < 1900)
                        return View();
                    
                    if(password2 != organizerModel.password)
                        return View();
                    
                    RegisteredUserModel registered = db.Registrovani.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    UnregistredUserModel unregistred = db.Neregistrovani.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    OrganizerModel organizer = db.Oranizatori.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    LocalAdministratorModel local = db.Lokalni.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    MainAdministratorModel main = db.Glavni.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    if (!(registered == null && unregistred == null && organizer == null && local == null && main == null))
                        return View();
                    
                    _context.Add(organizerModel);
                    await _context.SaveChangesAsync();
                    
                    HttpContext.Session.SetString("role", "Organizer");
                    HttpContext.Session.SetInt32("id", organizerModel.OrganizerModelId);
                    return RedirectToAction("Index", "Home");
                }
                
            }
            return View(organizerModel);
        }

        // GET: Organizer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            if (id == null)
            {
                return NotFound();
            }

            var organizerModel = await _context.Oranizatori.FindAsync(id);
            if (organizerModel == null)
            {
                return NotFound();
            }
            return View(organizerModel);
        }

        // POST: Organizer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrganizerModelId,Name,Surname,Address,DateOfBirth,Username,password")] OrganizerModel organizerModel, string password2)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            organizerModel.OrganizerModelId = id;

            if (ModelState.IsValid)
            {
                using (var db = new DatabaseContext())
                {
                    if (organizerModel.DateOfBirth.CompareTo(DateTime.Now) >= 0 ||
                        organizerModel.DateOfBirth.Year < 1900)
                        return View();

                    if(!(password2 == null || password2.Length == 0) && (organizerModel.password == null || organizerModel.password.Length == 0))
                        return View();
                    
                    if((password2 == null || password2.Length == 0) && !(organizerModel.password == null || organizerModel.password.Length == 0))
                        return View();
                    
                    if (!(password2 == null || password2.Length == 0) && !(organizerModel.password == null || organizerModel.password.Length == 0) && password2 != organizerModel.password)
                        return View();
                    
                    

                    OrganizerModel currentRegistered = db.Oranizatori.Where(e => e.OrganizerModelId == HttpContext.Session.GetInt32("id")).FirstOrDefault();
                    
                    RegisteredUserModel registered = db.Registrovani.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    UnregistredUserModel unregistred = db.Neregistrovani.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    OrganizerModel organizer = db.Oranizatori.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    LocalAdministratorModel local = db.Lokalni.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    MainAdministratorModel main = db.Glavni.Where(e => e.Username == organizerModel.Username).FirstOrDefault();

                    if (!(registered == null && unregistred == null && organizer == null && local == null && main == null) && currentRegistered.Username != organizerModel.Username)
                        return View();

                    if (organizerModel.password == null || organizerModel.password.Length == 0)
                        organizerModel.password = currentRegistered.password;
                }
                
                
                try
                {
                    _context.Update(organizerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizerModelExists(organizerModel.OrganizerModelId))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction("Index", "Home");
            }
            return View(organizerModel);
        }

        // GET: Organizer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizerModel = await _context.Oranizatori
                .FirstOrDefaultAsync(m => m.OrganizerModelId == id);
            if (organizerModel == null)
            {
                return NotFound();
            }

            return View(organizerModel);
        }

        // POST: Organizer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var organizerModel = await _context.Oranizatori.FindAsync(id);
            _context.Oranizatori.Remove(organizerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizerModelExists(int id)
        {
            return _context.Oranizatori.Any(e => e.OrganizerModelId == id);
        }
    }
}
