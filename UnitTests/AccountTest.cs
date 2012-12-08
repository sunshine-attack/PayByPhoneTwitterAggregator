using System;
using Xunit;

using PayByPhoneTwitterAggregator.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    public class AccountTest 
    {
        [Fact]
        public void TestNameProperty()
        {
            //Arrange
            var account = new Account("Not You");
            var expected = "PayByPhone";

            //Act
            account.Name = expected;

            //Assert
            Assert.Equal(expected, account.Name);  
        }
        
        [Fact]
        public void WhenAccountIsCreateTweetCollectionisIntialized()
        {
            //Arrange
            var account = new Account(String.Empty);

            //Assert
            Assert.NotNull(account.Tweets);
        }

        [Fact]
        public void TestTweetsPropertyForValidCollection()
        {
            //Arrange
            var account = new Account(String.Empty);
            var expected = 2;
            var tweet1 = new Tweet()
            {
                DateAndTime = DateTime.Now,
                Details = "This is a tweet",
                User = "PayByPhone"
            };
            var tweet2 = new Tweet()
            {
                DateAndTime = DateTime.Now,
                Details = "I'm tweeting",
                User = "PayByPhone"
            };

            //Act
            account.Tweets.Add(tweet1);
            account.Tweets.Add(tweet2);

            //Assert
            Assert.Equal(expected,account.Tweets.Count);
        }

        [Fact]
        public void TestTotalTweetsProperty()
        {
            //Arrange
            var account = new Account(String.Empty);
            var expected = 10;
            
            //Act
            account.TotalTweets = expected;

            //Assert
            Assert.Equal(expected, account.TotalTweets);

        }

        [Fact]
        public void TestTotalNumberofTimesAnotherUserWasMentionedProperty()
        {
            //Arrange
            var account = new Account(String.Empty);
            var expected = 50;

            //Act
            account.TotalNumberofTimesAnotherUserWasMentioned = expected;

            //Assert
            Assert.Equal(expected, account.TotalNumberofTimesAnotherUserWasMentioned);

        }

        [Fact]
        public void WhenAccountIsCreateNameIsSet()
        {
            //Arrange
            var expected = "Account Name";
            var account = new Account("Account Name");

            //Assert
            Assert.Equal(expected, account.Name);
        }


    }
}
