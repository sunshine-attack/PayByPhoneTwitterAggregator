using PayByPhoneTwitterAggregator.Services;
using System;
using PayByPhoneTwitterAggregator;
using Xunit;
using PayByPhoneTwitterAggregator.Entities;

namespace UnitTest
{
    public class LoadAccountDetailsServiceTest
    {
        [Fact]
        public void WhenPopulatedAccountIsCalledAndAnAccountIsProvidedTheAccountIsPopulated()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var calculateTweetAggregates = new CalculateTweetAggregatesService();
            var loadAccountDetailsService = new LoadAccountDetailsService(twitterAccessService, calculateTweetAggregates);
            var account = new Account("PayByPhone");

            //Act
            loadAccountDetailsService.PopulatedAccount(account, 1);

            //Assert
            Assert.NotNull(account.Name);
            Assert.NotNull(account.Tweets);
        }
    }
}
