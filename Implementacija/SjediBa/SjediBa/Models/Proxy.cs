using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SjediBa.Models
{
    public class ProxyModel
    {
        public ProxyModel(AccountModel account, int id)
        {
            Id = id;
            this.Account = account;
        }
        public int Id { get; set; }
        public AccountModel Account { get; set; }

        public void Check() { }

    }
}
