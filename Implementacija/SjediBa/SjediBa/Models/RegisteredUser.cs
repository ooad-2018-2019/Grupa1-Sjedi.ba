using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class RegisteredUserModel : UserModel
    {

        public List<ReservationModel> Reservations { get; set; }
        public List<NotificationModel> Notifications { get; set; }

        public RegisteredUserModel(string name, string surname, string address, DateTime dateOfBirth, List<ReservationModel> reservations, List<NotificationModel> notifications, int id) : base(name, surname, address, dateOfBirth,id)
        {

            this.Reservations = reservations;
            this.Notifications = notifications;
            
        }
    }
}
