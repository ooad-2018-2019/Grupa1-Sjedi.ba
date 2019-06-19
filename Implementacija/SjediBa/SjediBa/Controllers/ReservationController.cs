using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class ReservationController : Controller
    {
        private DatabaseContext _context;
        public IActionResult Reservation(DatabaseContext context)
        {
            _context = context;
            ViewData["role"] = HttpContext.Session.GetString("role");
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            return View();
        }


        [HttpPost]
        public static List<EventModel> GetEvents(){
            using (var db = new DatabaseContext())
            {
                List<EventModel> events = new List<EventModel>();

                events = db.dogad.ToList();

                foreach (var eventModel in events)
                {
                    
                    eventModel.SpaceModel = db.Lokacije.Where(e => e.SpaceModelId == eventModel.SpaceModelId).First();
                    eventModel.OrganizerModel = db.Oranizatori.Where(e => e.OrganizerModelId == eventModel.OrganizerModelId).First();

                    eventModel.SpaceModel.SectionModels = db.Sektori.Where(e => e.SpaceModelId == eventModel.SpaceModelId).ToList();

                    List<ReservationModel> rezervisana = db.Rezervacija.Where(e => e.EventModelId == eventModel.EventModelId).ToList();
                    for (int i = 0; i < eventModel.SpaceModel.SectionModels.Count; i++)
                    {
                        eventModel.SpaceModel.SectionModels.ElementAt(i).SeatModels = db.Sjedista.Where(e => e.SectionModelId == eventModel.SpaceModel.SectionModels.ElementAt(i).SectionModelId).ToList();
                        
                    }
                    foreach (var rezervacija in rezervisana)
                    {
                        foreach (var sektor in eventModel.SpaceModel.SectionModels)
                        {
                            for (int i = 0; i < sektor.SeatModels.Count; i++)
                            {
                                if (sektor.SeatModels.ElementAt(i).SeatModelId == rezervacija.SeatModelId)
                                {
                                    ((List<SeatModel>)sektor.SeatModels).RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                            
                    }

                    




                }
                return events;
            }
        }

        [HttpPost]
        public static RegisteredUserModel getCurrentForReservation(int id)
        {
            using (var db = new DatabaseContext())
            {
                RegisteredUserModel Current = db.Registrovani.Where(e => e.UserModelId == id).FirstOrDefault();

                return Current;
            }
        }

        [HttpPost]
        public IActionResult ReservationInput(string name, string surname, string address, string date,int seat, int eventid,int userid)
        {
            ReservationModel r = new ReservationModel();

            if (userid == 0)
            {
                if(name == null || surname == null || address == null || seat == 0 || name == ""|| surname == "" || address =="" )
                    return RedirectToAction("Index", "Home");
                UnregistredUserModel u = new UnregistredUserModel();
                u.Name = name;
                u.Surname = surname;
                u.Address = address;
                // u.DateOfBirth = DateTime.Parse(date);
                u.DateOfBirth = DateTime.Now;
                u.Username = "";
                u.password = "";
            
                r.UserModel = u;
                r.EventModelId = eventid;
                r.SeatModelId = seat;                
            }
            else
            {
                r.UserModelId = userid;
                r.EventModelId = eventid;
                r.SeatModelId = seat;
            }

            using (var db = new DatabaseContext())
            {
             
                db.Rezervacija.Add(r);
                db.SaveChanges();  

            }

            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
    
}
