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

        // public UserModel(string name, string surname, string address, DateTime dateOfBirth,int id)
        // {
        //     Id = id;
        //     this.Name = name;
        //     this.Surname = surname;
        //     this.Address = address;
        //     this.DateOfBirth = dateOfBirth;
        // }

    }
}
