using System;
using Xunit;
using PayByPhoneTwitterAggregator.Entities;
using System.Collections.Generic;
using PayByPhoneTwitterAggregator.Services;
using PayByPhoneTwitterAggregator;

namespace UnitTest
{
    class AccountManagerTest
    {

        [Fact]
        public void WhenGetAccountIsCalledTheAccountsAreReturned()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var calculateTweetAggregates = new CalculateTweetAggregatesService();
            var loadAccountDetailsService = new LoadAccountDetailsService(twitterAccessService, calculateTweetAggregates);
            var accountManager = new AccountManagerService(loadAccountDetailsService);
            var expected = 1;

            //Act
            accountManager.CreateAccount("PayByPhone_UK", 3);
            var accounts = accountManager.GetAccounts();

            //Assert
            Assert.Equal(expected, accounts.Count);

        }

        [Fact]
        public void WhenCreateEmptyAccountIsCalledAPopulatedAccountIsCreated()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var calculateTweetAggregates = new CalculateTweetAggregatesService();
            var loadAccountDetailsService = new LoadAccountDetailsService(twitterAccessService, calculateTweetAggregates);
            var accountManager = new AccountManagerService(loadAccountDetailsService);

            //Act
            accountManager.CreateAccount("PayByPhone_UK", 14);

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
