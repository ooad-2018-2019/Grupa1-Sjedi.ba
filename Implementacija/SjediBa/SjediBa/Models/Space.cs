using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SpaceModel
    {
        public SpaceModel(string address, List<SectionModel> sections, LocalAdministratorModel localAdministrator,int id)
        {
            Id = id;
            Address = address;
            Sections = sections;
            LocalAdministrator = localAdministrator;
        }
        public int Id { get; set; }
        public string Address { get; set; }
        public List<SectionModel> Sections { get; set; }
        public LocalAdministratorModel LocalAdministrator { get; set; }

    }
}
