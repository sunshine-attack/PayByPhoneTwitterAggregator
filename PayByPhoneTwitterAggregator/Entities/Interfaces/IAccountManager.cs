using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface IAccountManager
    {
       
         void CreateEmptyAccount(String name);
         List<Account> GetAccounts();

    }
}
