using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class OrganizerModel : UserModel
    {
       
        public ICollection<EventModel> EventModels { get; set; } = new List<EventModel>();
    }
}
