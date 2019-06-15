using System;

namespace SjediBa.Models
{
    public class EventModel
    {
        public EventModel(OrganizerModel organizer, SpaceModel space, DateTime startDate, DateTime endTime,int id)
        {
            Id = id;
            Organizer = organizer;
            Space = space;
            StartDate = startDate;
            EndTime = endTime;
        }
        public int Id { get; set; }
        public OrganizerModel Organizer { get; set; }
        public SpaceModel Space { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
    }
}