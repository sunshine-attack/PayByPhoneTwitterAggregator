using PayByPhoneTwitterAggregator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using PayByPhoneTwitterAggregator.Services.Interfaces;

namespace PayByPhoneTwitterAggregator.Entities
{
    public class AccountManager:IAccountManager
    {
        LoadAccountDetailsService accountDetailsService;
        List<Account> accounts;

        public AccountManager(LoadAccountDetailsService accountDetailsService)
        {
            this.accountDetailsService = accountDetailsService;
            accounts = new List<Account>();
        }

        public void CreateEmptyAccount(String name)
        {
            var account = new Account(name);
            accountDetailsService.Populate(ref account);
            accounts.Add(account);
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }

    }
}