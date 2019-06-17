using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class RegisteredUserModel : UserModel
    {
        // public int RegistredUserModelId { get; set; }
        public int AccountModelId { get; set; }
        public AccountModel AccountModel { get; set; }
        public ICollection<ReservationModel> ReservationModels { get; set; } = new List<ReservationModel>();
        public ICollection<NotificationModel> NotificationModels { get; set; } = new List<NotificationModel>();
    }
}
