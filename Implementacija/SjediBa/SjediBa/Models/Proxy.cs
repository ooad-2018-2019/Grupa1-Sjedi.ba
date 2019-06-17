using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{

    public class ProxyModel
    {
         public ProxyModel(AccountModel account)
         {
         
             this.Account = account;
         }
        public AccountModel Account { get; set; }

        public void Check() { }

    }

}
