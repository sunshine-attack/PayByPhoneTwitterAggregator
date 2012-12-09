using PayByPhoneTwitterAggregator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using PayByPhoneTwitterAggregator.Entities;

namespace PayByPhoneTwitterAggregator.Services
{
    public class AccountManager:IAccountManager
    {
        LoadAccountDetailsService accountDetailsService;
        List<IAccount> accounts;

        public AccountManager(LoadAccountDetailsService accountDetailsService)
        {
            this.accountDetailsService = accountDetailsService;
            accounts = new List<IAccount>();
        }

        public void CreateAccount(String name)
        {
            var account = new Account(name);
            accountDetailsService.Populate(ref account);
            accounts.Add(account);
        }

        public List<IAccount> GetAccounts()
        {
            return accounts;
        }

    }
}