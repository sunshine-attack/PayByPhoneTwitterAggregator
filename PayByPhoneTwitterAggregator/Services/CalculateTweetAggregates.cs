using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayByPhoneTwitterAggregator.Services
{
    public class CalculateTweetAggregates : ICalculateTweetAggregates
    {
        public void CalculateTotalTweets(ref Account account)
        {
            account.TotalTweets = account.Tweets.Count();
        }

        public void CalculateTotalNumberofTimesAnotherUserWasMentioned(ref Account account)
        {

            int mentionedUserCount = 0;

            foreach (var tweet in account.Tweets)
            {
                if (tweet.User != account.Name) mentionedUserCount++;
            }

            account.TotalNumberofTimesAnotherUserWasMentioned = mentionedUserCount;
        }

    }
}