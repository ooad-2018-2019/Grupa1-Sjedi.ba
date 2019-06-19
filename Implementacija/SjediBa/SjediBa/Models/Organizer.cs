using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class OrganizerModel
    {
        public int OrganizerModelId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Username { get; set; }
        
        public string password { get; set; }
        
    }
}
