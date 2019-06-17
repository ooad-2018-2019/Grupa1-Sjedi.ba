using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SectionModel
    {
        
        public int SectionModelId { get; set; }
        public ICollection<SeatModel> SeatModels { get; set; } = new List<SeatModel>();
        public int SeatPrices { get; set; }
        public string Name { get; set; }

    }
}
