using System;
using Xunit;
using PayByPhoneTwitterAggregator.Entities;
using System.Collections.Generic;

namespace UnitTests
{
    class AccountManagerTest
    {
        [Fact]
        public void TestNameProperty()
        {
            //Arrange
            var account = new Account("Not You");
            var expected = "PayByPhone";

            //Act
            account.Name = "poof";//expected;

            //Assert
            Assert.Equal(expected, account.Name);
        }
        
    }
}
