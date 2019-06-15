using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class ReservationModel
    {
        public ReservationModel(EventModel @event, SeatModel seat,int id)
        {
            Id = id;
            Event = @event;
            Seat = seat;
        }
        public int Id { get; set; }
        public EventModel Event { get; set; }
        public SeatModel Seat { get; set; }


    }
}
