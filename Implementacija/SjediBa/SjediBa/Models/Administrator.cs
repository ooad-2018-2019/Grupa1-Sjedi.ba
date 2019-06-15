using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class AdministratorModel
    {
        public AdministratorModel(string name, string surname, DateTime dateOfBirth, string address, ProxyModel account,int id)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Address = address;
            Account = account;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public ProxyModel Account { get; set; }


    }
}
