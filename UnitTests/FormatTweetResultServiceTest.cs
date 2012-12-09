using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Services;
using System;
using TwitterAccess;
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
            var accountDetailsService = new LoadAccountDetailsService(twitterAccessService);
            var accountManager = new AccountManager(accountDetailsService);
            accountManager.CreateAccount("PayByPhone_UK");
            var accounts = accountManager.GetAccounts();

            //Act
            var twitterResultService = new FormatTweetResultService();
            var tweetResult = twitterResultService.CreateTweetResult(accounts);

            //Assert
            Assert.NotNull(tweetResult);

        }
    }
}
