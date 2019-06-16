using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class RegisteredUserModel : UserModel
    {

        public ICollection<ReservationModel> ReservationModels { get; set; } = new List<ReservationModel>();
        public ICollection<NotificationModel> NotificationModels { get; set; } = new List<NotificationModel>();

        // public RegisteredUserModel(string name, string surname, string address, DateTime dateOfBirth, List<ReservationModel> reservations, List<NotificationModel> notifications, int id) : base(name, surname, address, dateOfBirth,id)
        // {

        //     this.Reservations = reservations;
        //     this.Notifications = notifications;
            
        // }
    }
}
