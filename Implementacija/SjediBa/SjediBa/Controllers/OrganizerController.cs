using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            return View(await _context.Oranizatori.ToListAsync());
        }

        // GET: Organizer/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Organizer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Organizer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrganizerModelId,Name,Surname,Address,DateOfBirth,Username,password")] OrganizerModel organizerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organizerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(organizerModel);
        }

        // GET: Organizer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
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
        public async Task<IActionResult> Edit(int id, [Bind("OrganizerModelId,Name,Surname,Address,DateOfBirth,Username,password")] OrganizerModel organizerModel)
        {
            if (id != organizerModel.OrganizerModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
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
