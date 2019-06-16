using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class ReservationModel
    {
        // public ReservationModel(EventModel @event, SeatModel seat,int id)
        // {
        //     Id = id;
        //     Event = @event;
        //     Seat = seat;
        // }
        public int ReservationModelId { get; set; }
        public int EventModelId { get; set; }
        public EventModel EventModel { get; set; }
        public int SeatModelId { get; set; }
        public SeatModel SeatModel { get; set; }


    }
}
