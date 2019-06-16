using System;
using System.Runtime.Serialization;

namespace SjediBa.Models
{
    public class EventModel 
    {
        
        public int EventModelId { get; set; }
        public string Name { get; set;}
        public int OrganizerModelId { get; set; }
        public OrganizerModel OrganizerModel { get; set; }
        public int SpaceModelId { get; set; }
        public SpaceModel SpaceModel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}