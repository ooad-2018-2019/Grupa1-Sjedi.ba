using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SectionModel
    {
        public SectionModel(List<SeatModel> seats, int seatPrices,int id)
        {
            Id = id;
            Seats = seats;
            SeatPrices = seatPrices;
        }
        public int Id { get; set; }
        public List<SeatModel> Seats { get; set; }
        public int SeatPrices { get; set; }

    }
}
