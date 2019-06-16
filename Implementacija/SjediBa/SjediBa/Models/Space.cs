using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SpaceModel
    {
        
        public int SpaceModelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<SectionModel> SectionModels { get; set; } = new List<SectionModel>();
        public int LocalAdministratorModelId { get; set; }
        public LocalAdministratorModel LocalAdministratorModel { get; set; }

    }
}
