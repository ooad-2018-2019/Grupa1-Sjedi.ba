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
    public class SeatController : Controller
    {
        private readonly DatabaseContext _context;

        public SeatController(DatabaseContext context)
        {
         //   _context = context;
        }

        // GET: Seat
        public async Task<IActionResult> Index()
        {
//            var databaseContext = _context.Sjedista.Include(s => s.SectionModel);
//            return View(await databaseContext.ToListAsync());
            return null;
        }

        // GET: Seat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var seatModel = await _context.Sjedista
//                .Include(s => s.SectionModel)
//                .FirstOrDefaultAsync(m => m.SeatModelId == id);
//            if (seatModel == null)
//            {
//                return NotFound();
//            }
//
//            return View(seatModel);
            return null;

        }

        // GET: Seat/Create
        public IActionResult Create()
        {
//            ViewData["SectionModelId"] = new SelectList(_context.Sektori, "SectionModelId", "SectionModelId");
//            return View();
            return null;

        }

        // POST: Seat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionModelId,SeatModelId,RowSeat")] SeatModel seatModel)
        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(seatModel);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["SectionModelId"] = new SelectList(_context.Sektori, "SectionModelId", "SectionModelId", seatModel.SectionModelId);
//            return View(seatModel);
            return null;

        }

        // GET: Seat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var seatModel = await _context.Sjedista.FindAsync(id);
//            if (seatModel == null)
//            {
//                return NotFound();
//            }
//            ViewData["SectionModelId"] = new SelectList(_context.Sektori, "SectionModelId", "SectionModelId", seatModel.SectionModelId);
//            return View(seatModel);
            return null;

        }

        // POST: Seat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SectionModelId,SeatModelId,RowSeat")] SeatModel seatModel)
        {
//            if (id != seatModel.SeatModelId)
//            {
//                return NotFound();
//            }
//
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(seatModel);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!SeatModelExists(seatModel.SeatModelId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["SectionModelId"] = new SelectList(_context.Sektori, "SectionModelId", "SectionModelId", seatModel.SectionModelId);
//            return View(seatModel);
            return null;

        }

        // GET: Seat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var seatModel = await _context.Sjedista
//                .Include(s => s.SectionModel)
//                .FirstOrDefaultAsync(m => m.SeatModelId == id);
//            if (seatModel == null)
//            {
//                return NotFound();
//            }
//
//            return View(seatModel);
            return null;

        }

        // POST: Seat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
//            var seatModel = await _context.Sjedista.FindAsync(id);
//            _context.Sjedista.Remove(seatModel);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
            return null;

        }

        private bool SeatModelExists(int id)
        {
            return _context.Sjedista.Any(e => e.SeatModelId == id);
        }
    }
}
