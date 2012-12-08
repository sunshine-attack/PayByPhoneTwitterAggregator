using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface IAccountManager
    {
       
        public void CreateEmptyAccount(String name);
        public List<Account> GetAccounts();

    }
}
