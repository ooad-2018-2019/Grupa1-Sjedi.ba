using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SeatModel
    {
        public SeatModel(string rowSeat,int id)
        {
          RowSeat = rowSeat;
            Id = id;
        }
        public int Id { get; set; }
        public string RowSeat { get; set; }

    }
}
