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
                return RedirectToAction("Index", "Home");
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
                return RedirectToAction("Index", "Home");
            }
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator", spaceModel.LocalAdministratorModelId);
            return View(spaceModel);
        }

        private bool SpaceModelExists(int id)
        {
            return _context.Lokacije.Any(e => e.SpaceModelId == id);
        }
    }
}
