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
    public class LocalAdministratorController : Controller
    {
        private readonly DatabaseContext _context;

        public LocalAdministratorController(DatabaseContext context)
        {
            _context = context;
        }

        

       
        // GET: LocalAdministrator/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocalAdministrator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdministratorModelId,Name,Surname,DateOfBirth,Address,Username,Password")] LocalAdministratorModel localAdministratorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localAdministratorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(localAdministratorModel);
        }

        // GET: LocalAdministrator/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localAdministratorModel = await _context.Lokalni.FindAsync(id);
            if (localAdministratorModel == null)
            {
                return NotFound();
            }
            return View(localAdministratorModel);
        }

        // POST: LocalAdministrator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdministratorModelId,Name,Surname,DateOfBirth,Address,Username,Password")] LocalAdministratorModel localAdministratorModel)
        {
            if (id != localAdministratorModel.AdministratorModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localAdministratorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalAdministratorModelExists(localAdministratorModel.AdministratorModelId))
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
            return View(localAdministratorModel);
        }

        // GET: LocalAdministrator/Delete/5
       

        // POST: LocalAdministrator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var localAdministratorModel = await _context.Lokalni.FindAsync(id);
            _context.Lokalni.Remove(localAdministratorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        private bool LocalAdministratorModelExists(int id)
        {
            return _context.Lokalni.Any(e => e.AdministratorModelId == id);
        }
    }
}
