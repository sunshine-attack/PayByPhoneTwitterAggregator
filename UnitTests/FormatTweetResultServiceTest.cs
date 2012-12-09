using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Services;
using System;
using PayByPhoneTwitterAggregator;
using Xunit;

namespace UnitTest
{

    public class FormatTweetResultServiceTest
    {
        [Fact]
        public void WhenCreateTweetResultisCalledandAnAccountIsProvideATweetResultIsReturned()
        {
            //Arrange
            var twitterAccessService = new TwitterAccessService();
            var calculateTweetAggregates = new CalculateTweetAggregatesService();
            var loadAccountDetailsService = new LoadAccountDetailsService(twitterAccessService, calculateTweetAggregates);
            var accountManager = new AccountManagerService(loadAccountDetailsService);
            accountManager.CreateAccount("PayByPhone_UK", 14);
            var accounts = accountManager.GetAccounts();

            //Act
            var twitterResultService = new FormatTweetResultService();
            var tweetResult = twitterResultService.CreateTweetResult(accounts);

            //Assert
            Assert.NotNull(tweetResult);

        }
    }
}
