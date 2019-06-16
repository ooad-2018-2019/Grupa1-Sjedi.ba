using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SectionModel
    {
        // public SectionModel(List<SeatModel> seats, int seatPrices, string name, int id)
        // {
        //     Id = id;
        //     Name = name;
        //     Seats = seats;
        //     SeatPrices = seatPrices;
        // }
        public int SectionModelId { get; set; }
        public ICollection<SeatModel> SeatModels { get; set; } = new List<SeatModel>();
        // public List<SeatModel> SeatModels { get; set; }
        public int SeatPrices { get; set; }
        
        public string Name { get; set; }

    }
}
