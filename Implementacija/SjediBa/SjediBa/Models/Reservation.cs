using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class ReservationModel
    {
        public int ReservationModelId { get; set; }
        public int EventModelId { get; set; }
        public EventModel EventModel { get; set; }
        public int SeatModelId { get; set; }
        public SeatModel SeatModel { get; set; }
        public int UserModelId { get; set; }
        public UserModel UserModel { get; set; }

    }
}
