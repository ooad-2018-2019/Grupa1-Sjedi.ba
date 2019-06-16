using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class OrganizerModel : UserModel
    {
        // public OrganizerModel(string name, string surname, string address, DateTime dateOfBirth, ProxyModel account,int id) : base(name, surname, address, dateOfBirth,id )
        // {
        //     Account = account;
        // }

        // public int ProxyModelId { get; set; }
        // public ProxyModel ProxyModel { get; set; }

        public ICollection<EventModel> EventModels { get; set; } = new List<EventModel>();
    }
}
