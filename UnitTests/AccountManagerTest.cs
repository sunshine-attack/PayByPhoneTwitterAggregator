using System;
using Xunit;
using PayByPhoneTwitterAggregator.Entities;
using System.Collections.Generic;
using PayByPhoneTwitterAggregator.Services;
using TwitterAccess;

namespace UnitTest
{
    class AccountManagerTest
    {

        [Fact]
        public void WhenGetAccountIsCalledTheAccountsAreReturned()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var accountDetailsService = new LoadAccountDetailsService(twitterAccessService);
            var accountManager = new AccountManager(accountDetailsService);
            var expected = 1;

            //Act
            accountManager.CreateAccount("PayByPhone_UK");
            var accounts = accountManager.GetAccounts();

            //Assert
            Assert.Equal(expected, accounts.Count);

        }

        [Fact]
        public void WhenCreateEmptyAccountIsCalledAPopulatedAccountIsCreated()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var accountDetailsService = new LoadAccountDetailsService(twitterAccessService);
            var accountManager = new AccountManager(accountDetailsService);

            //Act
            accountManager.CreateAccount("PayByPhone_UK");

            //Assert
            var accounts = accountManager.GetAccounts();
            foreach (var account in accounts)
            {
                Assert.NotNull(account.Name);
                Assert.True(account.Tweets.Count > 1);
                Assert.True(account.TotalTweets > 1);
            }

        }
    }

}
