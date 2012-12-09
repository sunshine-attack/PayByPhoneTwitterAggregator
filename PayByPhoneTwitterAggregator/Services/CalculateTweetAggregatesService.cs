using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Aggregates the tweet data for the Account Entities
 */

namespace PayByPhoneTwitterAggregator.Services
{
    public class CalculateTweetAggregatesService:ICalculateTweetAggregatesService
    {
        public int CalculateTotalTweets(IAccount account)
        {
            return account.Tweets.Count();
        }

        public int CalculateTotalNumberofTimesAnotherUserWasMentioned(IAccount account)
        {
            int mentionedUserCount = 0;

            foreach (var tweet in account.Tweets)
            {
                mentionedUserCount += tweet.Mentions;
            }

            return mentionedUserCount;
        }

    }
}