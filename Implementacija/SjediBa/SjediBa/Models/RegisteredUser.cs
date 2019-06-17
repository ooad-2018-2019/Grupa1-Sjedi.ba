using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class RegisteredUserModel : UserModel
    {
        // public int RegistredUserModelId { get; set; }
        
        public ICollection<NotificationModel> NotificationModels { get; set; } = new List<NotificationModel>();
    }
}
