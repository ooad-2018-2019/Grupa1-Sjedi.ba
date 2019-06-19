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
    public class SpaceController : Controller
    {
        private readonly DatabaseContext _context;
        private static List<SectionModel> SectionModels = new List<SectionModel>();

        public SpaceController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Space/Create
        public IActionResult Create()
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator");
            return View();
        }

        // POST: Space/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpaceModelId,Name,Address,LocalAdministratorModelId")] SpaceModel spaceModel, string AdminName, string Surename, string Date, string AdminAddress, string Username, string Password, string Password2)
        {
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            
            if (ModelState.IsValid)
            {

                
                    if(DateTime.Parse(Date).CompareTo(DateTime.Now) >= 0 || DateTime.Parse(Date).Year < 1900)
                        return View();
                    
                    if(Password != Password2)
                        return View();
                    
                    RegisteredUserModel registered = _context.Registrovani.Where(e => e.Username == Username).FirstOrDefault();

                    UnregistredUserModel unregistred = _context.Neregistrovani.Where(e => e.Username == Username).FirstOrDefault();

                    OrganizerModel organizer = _context.Oranizatori.Where(e => e.Username == Username).FirstOrDefault();

                    LocalAdministratorModel local = _context.Lokalni.Where(e => e.Username == Username).FirstOrDefault();

                    MainAdministratorModel main = _context.Glavni.Where(e => e.Username == Username).FirstOrDefault();

                    if (!(registered == null && unregistred == null && organizer == null && local == null && main == null))
                        return View();
                
                    
                    if(SectionModels.Count == 0) return View();
                    
                    LocalAdministratorModel localAdministratorModel = new LocalAdministratorModel();
                    localAdministratorModel.Name = AdminName;
                    localAdministratorModel.Surname = Surename;
                    localAdministratorModel.Username = Username;
                    localAdministratorModel.Password = Password;
                    localAdministratorModel.Address = AdminAddress;
                    localAdministratorModel.DateOfBirth = DateTime.Parse(Date);

                    _context.Add(localAdministratorModel);
                    await _context.SaveChangesAsync();

                    spaceModel.LocalAdministratorModelId = localAdministratorModel.AdministratorModelId;
                    spaceModel.LocalAdministratorModel = localAdministratorModel;
                    
                    _context.Add(spaceModel);
                    await _context.SaveChangesAsync();

                    foreach (SectionModel sectionModel in SectionModels)
                    {
                        sectionModel.SpaceModelId = spaceModel.SpaceModelId;
                        _context.Add(sectionModel);
                        await _context.SaveChangesAsync();
                        foreach (SeatModel seatModel in sectionModel.SeatModels)
                        {
                            
                            seatModel.SectionModelId = sectionModel.SectionModelId;
                            _context.Add(seatModel);
                            await _context.SaveChangesAsync();
                        }
                        
                    }
                    
                    SectionModels.Clear();    
                    return RedirectToAction("Index", "Home");
                
                
            }
            ViewData["LocalAdministratorModelId"] = new SelectList(_context.Lokalni, "AdministratorModelId", "Discriminator", spaceModel.LocalAdministratorModelId);
            return View(spaceModel);
        }


        public IActionResult AddSection(string SectorName, string SeatPrice, string NumberOfSeats)
        {
            if(Int32.Parse(NumberOfSeats) < 1 || Int32.Parse(SeatPrice) < 1)
                return RedirectToAction("Create");
            
            SectionModels.Add(new SectionModel());
            SectionModels[SectionModels.Count - 1].Name = SectorName;
            SectionModels[SectionModels.Count - 1].SeatPrices = Int32.Parse(SeatPrice);
            SectionModels[SectionModels.Count - 1].SeatModels = new List<SeatModel>();

            for (int i = 0; i < Int32.Parse(NumberOfSeats); i++)
            {
                SectionModels[SectionModels.Count - 1].SeatModels.Add(new SeatModel());
                SectionModels[SectionModels.Count - 1].SeatModels
                        .ElementAt(SectionModels[SectionModels.Count - 1].SeatModels.Count - 1).RowSeat =
                    SectorName + " Sjediste " + (i + 1);
            }

            return RedirectToAction("Create");
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
