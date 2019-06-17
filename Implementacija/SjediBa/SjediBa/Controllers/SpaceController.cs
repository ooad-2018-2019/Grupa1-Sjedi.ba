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
    public class SpaceController : Controller
    {
        private readonly DatabaseContext _context;

        public SpaceController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Space
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Lokacije.Include(s => s.LocalAdministratorModel);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Space/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spaceModel = await _context.Lokacije
                .Include(s => s.LocalAdministratorModel)
                .FirstOrDefaultAsync(m => m.SpaceModelId == id);
            if (spaceModel == null)
            {
                return NotFound();
            }

            return View(spaceModel);
        }

        // GET: Space/Create
        public IActionResult Create()
        {
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator");
            return View();
        }

        // POST: Space/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpaceModelId,Name,Address,LocalAdministratorModelId")] SpaceModel spaceModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spaceModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator", spaceModel.LocalAdministratorModelId);
            return View(spaceModel);
        }

        // GET: Space/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spaceModel = await _context.Lokacije.FindAsync(id);
            if (spaceModel == null)
            {
                return NotFound();
            }
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator", spaceModel.LocalAdministratorModelId);
            return View(spaceModel);
        }

        // POST: Space/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpaceModelId,Name,Address,LocalAdministratorModelId")] SpaceModel spaceModel)
        {
            if (id != spaceModel.SpaceModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spaceModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpaceModelExists(spaceModel.SpaceModelId))
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
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator", spaceModel.LocalAdministratorModelId);
            return View(spaceModel);
        }

        // GET: Space/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spaceModel = await _context.Lokacije
                .Include(s => s.LocalAdministratorModel)
                .FirstOrDefaultAsync(m => m.SpaceModelId == id);
            if (spaceModel == null)
            {
                return NotFound();
            }

            return View(spaceModel);
        }

        // POST: Space/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spaceModel = await _context.Lokacije.FindAsync(id);
            _context.Lokacije.Remove(spaceModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpaceModelExists(int id)
        {
            return _context.Lokacije.Any(e => e.SpaceModelId == id);
        }
    }
}
