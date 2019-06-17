using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class SeatModel
    {
        public int SectionModelId { get; set; }
        public SectionModel SectionModel { get; set; }
        public int SeatModelId { get; set; }
        public string RowSeat { get; set; }

    }
}
