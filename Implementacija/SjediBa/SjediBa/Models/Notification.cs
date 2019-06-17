using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class NotificationModel
    {
        
        public int NotificationModelId { get; set; }
        public string Notification { get; set; }
        public int RegisteredUserModelId { get; set; }
        public RegisteredUserModel RegisteredUserModel { get; set; }
    }
}
