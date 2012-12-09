using PayByPhoneTwitterAggregator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using PayByPhoneTwitterAggregator.Entities;

/*
 * The AccountManager, manages the Account entities and acts as their repository. 
 * Creating and loading them with data as needed
 */

namespace PayByPhoneTwitterAggregator.Services
{
    public class AccountManagerService:IAccountManagerService
    {
        LoadAccountDetailsService loadAccountDetailsService;
        List<IAccount> accounts;

        public AccountManagerService(LoadAccountDetailsService loadAccountDetailsService)
        {
            this.loadAccountDetailsService = loadAccountDetailsService;
            accounts = new List<IAccount>();
        }

        public void CreateAccount(String name, int days)
        {
            var account = new Account(name);
            loadAccountDetailsService.PopulatedAccount(account, days);
            accounts.Add(account);
        }

        public List<IAccount> GetAccounts()
        {
            return accounts;
        }

    }
}