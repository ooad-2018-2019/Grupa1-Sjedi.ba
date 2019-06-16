using System;
using System.Runtime.Serialization;

namespace SjediBa.Models
{
    public class EventModel 
    {
        public EventModel(OrganizerModel organizer, SpaceModel space, DateTime startDate, DateTime endDate, string name , int id)
        {
            Id = id;
            Name = name;
            Organizer = organizer;
            Space = space;
            StartDate = startDate;
            EndDate = endDate;
        }
        public int Id { get; set; }
        public string Name { get; set;}
        public OrganizerModel Organizer { get; set; }
        public SpaceModel Space { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}