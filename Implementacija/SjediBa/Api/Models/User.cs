using System;

namespace SjediBa.Models
{
    public class UserModel
    {
        public int UserModelId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
