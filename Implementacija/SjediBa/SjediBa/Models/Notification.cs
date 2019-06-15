using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class NotificationModel
    {
        public NotificationModel(EventModel @event)
        {
            Event = @event;
        }

        public EventModel Event { get; set; }

    }
}
