﻿using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    interface IAccountManager
    {
         void CreateEmptyAccount(String name);
         List<IAccount> GetAccounts();
    }
}
