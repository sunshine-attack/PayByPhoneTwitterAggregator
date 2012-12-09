using System;
using Xunit;
using PayByPhoneTwitterAggregator.Entities;
using System.Collections.Generic;
using PayByPhoneTwitterAggregator.Services;
using TwitterAccess;

namespace UnitTests
{
    class AccountManagerTest
    {
        //LoadAccountDetailsService accountDetailsService;
        //List<Account> accounts;

        //public AccountManager(LoadAccountDetailsService accountDetailsService)
        //{
        //    this.accountDetailsService = accountDetailsService;
        //    accounts = new List<Account>();
        //}

        //public void CreateEmptyAccount(String name)
        //{
        //    var account = new Account(name);
            
        //    accountDetailsService.Populate(ref account);
        //    accounts.Add(account);
        //}

        //public List<Account> GetAccounts()
        //{
        //    return accounts;
        //}


        [Fact]
        public void WhenCreateEmptyAccountIsCalledAPopulateAccountIsCreated()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var accountDetailsService = new LoadAccountDetailsService(twitterAccessService);
            var accountManager = new AccountManager(accountDetailsService);

            //Act
            accountManager.CreateEmptyAccount("PayByPhone_UK");
           
            //Assert
            var accounts = accountManager.GetAccounts();
            foreach (var account in accounts)
	        {
		         Assert.True(account.Tweets.Count > 1);
                Assert.NotNull(account.Name);
                Assert(account.TotalTweets
	        }
        
    }
}
