using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{

    public class ProxyModel
    {
        private string username;
        private string password;
         public ProxyModel(string username, string password)
         {
             this.username = username;
             this.password = password;
         }


         public Object Check()
         {
             if (username == null || password == null || username.Length == 0 || password.Length == 0)
                 return null;
             
            using (var db = new DatabaseContext())
            {
                RegisteredUserModel registered = db.Registrovani.Where(e => e.Username == username && e.password == password).FirstOrDefault();

                UnregistredUserModel unregistred = db.Neregistrovani.Where(e => e.Username == username && e.password == password).FirstOrDefault();

                OrganizerModel organizer = db.Oranizatori.Where(e => e.Username == username && e.password == password).FirstOrDefault();

                LocalAdministratorModel local = db.Lokalni.Where(e => e.Username == username && e.Password == password).FirstOrDefault();

                MainAdministratorModel main = db.Glavni.Where(e => e.Username == username && e.Password == password).FirstOrDefault();

                if (registered != null) return registered;

                if (organizer != null) return organizer;
                
                if (local != null) return local;

                if (main != null) return main;
              

                return unregistred;
            }
         }

    }

}
