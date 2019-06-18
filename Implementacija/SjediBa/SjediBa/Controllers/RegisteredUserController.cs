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
            return View(await _context.Registrovani.ToListAsync());
        }

        // GET: RegisteredUser/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: RegisteredUser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegisteredUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserModelId,Name,Surname,Address,DateOfBirth,Username,password")] RegisteredUserModel registeredUserModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registeredUserModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
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
        public async Task<IActionResult> Edit(int id, [Bind("UserModelId,Name,Surname,Address,DateOfBirth,Username,password")] RegisteredUserModel registeredUserModel)
        {
            if (id != registeredUserModel.UserModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                    else
                    {
                        throw;
                    }
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
