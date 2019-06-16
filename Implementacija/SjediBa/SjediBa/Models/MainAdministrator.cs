using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class MainAdministratorModel : AdministratorModel
    {
        // public MainAdministratorModel(string name, string surname, DateTime dateOfBirth, string address, ProxyModel account,int id) : base(name, surname, dateOfBirth, address, account,id)
        // {
        // }

        public int MainAdministratorModelId { get; set; }
    }
}
