using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class ProxyModel
    {
        // public ProxyModel(AccountModel account, int id)
        // {
        //     Id = id;
        //     this.Account = account;
        // }
        public int ProxyModelId { get; set; }
        public int AccountModelId { get; set; }
        public AccountModel AccountModel { get; set; }

        // public void Check() { }

    }
}
