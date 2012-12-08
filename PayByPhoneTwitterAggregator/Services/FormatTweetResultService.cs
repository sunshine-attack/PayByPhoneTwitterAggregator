using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Models;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayByPhoneTwitterAggregator.Services
{
    public class FormatTweetResultService : IFormatTweetResultService
    {
        TweetResult tweetResult;

        public TweetResult CreateTweetResult(List<Account> accounts)
        {

            tweetResult = new TweetResult();

            foreach (var account in accounts)
            {
                tweetResult.TotalTweetsPerAccount.Add(account.Name, account.TotalTweets);
                tweetResult.TotalNumberofTimesAnotherUserWasMentionedPerAccount.Add(account.Name, account.TotalNumberofTimesAnotherUserWasMentioned);

                foreach (var tweet in account.Tweets)
                {
                    tweetResult.Tweets.Add(new Models.Tweet { DateAndTime = tweet.DateAndTime, Details = tweet.Details, Account = account.Name });
                }

            }

            return tweetResult;

        }
    }

}