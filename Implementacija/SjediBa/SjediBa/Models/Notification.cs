using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class NotificationModel
    {
        // public NotificationModel(EventModel @event)
        // {
        //     Event = @event;
        // }

        public int NotificationModelId { get; set; }
        public string Notification { get; set; }

        // public int EventModelId { get; set; }
        // public EventModel EventModel { get; set; }

        public int RegisteredUserModelId { get; set; }
        public RegisteredUserModel RegisteredUserModel { get; set; }
    }
}
