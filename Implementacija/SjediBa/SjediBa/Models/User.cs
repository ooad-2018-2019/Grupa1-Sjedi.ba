using System;
using System.Collections.Generic;

namespace SjediBa.Models
{
    public class UserModel
    {
        public int UserModelId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Username { get; set; }
        
        public string password { get; set; }
        
        public ICollection<ReservationModel> ReservationModels { get; set; } = new List<ReservationModel>();

    }
}
