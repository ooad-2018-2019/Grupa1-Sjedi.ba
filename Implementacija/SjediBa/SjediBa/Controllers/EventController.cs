using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class EventController : Controller
    {
        private readonly DatabaseContext _context;

        public EventController(DatabaseContext context)
        {
            
            _context = context;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.dogad.Include(e => e.OrganizerModel).Include(e => e.SpaceModel);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Event/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventModel = await _context.dogad
                .Include(e => e.OrganizerModel)
                .Include(e => e.SpaceModel)
                .FirstOrDefaultAsync(m => m.EventModelId == id);
            if (eventModel == null)
            {
                return NotFound();
            }

            return View(eventModel);
        }

        // GET: Event/Create
        public IActionResult Create()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            ViewData["OrganizerModelId"] = new SelectList(_context.Oranizatori, "OrganizerModelId", "OrganizerModelId");
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId");
            ViewData["SpaceModelName"] = new SelectList(_context.Lokacije, "Name", "Name");
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventModelId,Name,OrganizerModelId,SpaceModelId,StartDate,EndDate")] EventModel eventModel, string SpaceModelId,int organizator)
        {
            if (ModelState.IsValid)
            {
                eventModel.OrganizerModelId = organizator;
                eventModel.SpaceModelId = Int32.Parse(SpaceModelId);

                _context.Add(eventModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["OrganizerModelId"] = new SelectList(_context.Oranizatori, "OrganizerModelId", "OrganizerModelId", eventModel.OrganizerModelId);
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", eventModel.SpaceModelId);
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId");
            ViewData["SpaceModelName"] = new SelectList(_context.Lokacije, "Name", "Name");
            return View(eventModel);
        }

        public static List<SpaceModel> GetSpaces()
        {
            using(var db = new DatabaseContext())
            {
                List<SpaceModel> spaceModels = db.Lokacije.ToList();
                return spaceModels;
            }            
        }

        // GET: Event/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventModel = await _context.dogad.FindAsync(id);
            if (eventModel == null)
            {
                return NotFound();
            }
            ViewData["OrganizerModelId"] = new SelectList(_context.Oranizatori, "OrganizerModelId", "OrganizerModelId", eventModel.OrganizerModelId);
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", eventModel.SpaceModelId);
            return View(eventModel);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventModelId,Name,OrganizerModelId,SpaceModelId,StartDate,EndDate")] EventModel eventModel)
        {
            if (id != eventModel.EventModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventModelExists(eventModel.EventModelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganizerModelId"] = new SelectList(_context.Oranizatori, "OrganizerModelId", "OrganizerModelId", eventModel.OrganizerModelId);
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", eventModel.SpaceModelId);
            return View(eventModel);
        }

        // GET: Event/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventModel = await _context.dogad
                .Include(e => e.OrganizerModel)
                .Include(e => e.SpaceModel)
                .FirstOrDefaultAsync(m => m.EventModelId == id);
            if (eventModel == null)
            {
                return NotFound();
            }

            return View(eventModel);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventModel = await _context.dogad.FindAsync(id);
            _context.dogad.Remove(eventModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventModelExists(int id)
        {
            return _context.dogad.Any(e => e.EventModelId == id);
        }
    }
}
