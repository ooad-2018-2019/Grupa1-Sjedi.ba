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
    public class SectionController : Controller
    {
        private readonly DatabaseContext _context;

        public SectionController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Section
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Sektori.Include(s => s.SpaceModel);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Section/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionModel = await _context.Sektori
                .Include(s => s.SpaceModel)
                .FirstOrDefaultAsync(m => m.SectionModelId == id);
            if (sectionModel == null)
            {
                return NotFound();
            }

            return View(sectionModel);
        }

        // GET: Section/Create
        public IActionResult Create()
        {
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId");
            return View();
        }

        // POST: Section/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionModelId,SpaceModelId,SeatPrices,Name")] SectionModel sectionModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sectionModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", sectionModel.SpaceModelId);
            return View(sectionModel);
        }

        // GET: Section/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionModel = await _context.Sektori.FindAsync(id);
            if (sectionModel == null)
            {
                return NotFound();
            }
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", sectionModel.SpaceModelId);
            return View(sectionModel);
        }

        // POST: Section/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SectionModelId,SpaceModelId,SeatPrices,Name")] SectionModel sectionModel)
        {
            if (id != sectionModel.SectionModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sectionModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionModelExists(sectionModel.SectionModelId))
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
            ViewData["SpaceModelId"] = new SelectList(_context.Lokacije, "SpaceModelId", "SpaceModelId", sectionModel.SpaceModelId);
            return View(sectionModel);
        }

        // GET: Section/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionModel = await _context.Sektori
                .Include(s => s.SpaceModel)
                .FirstOrDefaultAsync(m => m.SectionModelId == id);
            if (sectionModel == null)
            {
                return NotFound();
            }

            return View(sectionModel);
        }

        // POST: Section/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sectionModel = await _context.Sektori.FindAsync(id);
            _context.Sektori.Remove(sectionModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionModelExists(int id)
        {
            return _context.Sektori.Any(e => e.SectionModelId == id);
        }
    }
}
