using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
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

        public TweetResult CreateTweetResult(List<IAccount> accounts)
        {

            tweetResult = new TweetResult();
            var tweets = new List<Models.Tweet>();

            foreach (var account in accounts)
            {
                tweetResult.TotalTweetsPerAccount.Add(account.Name, account.TotalTweets);
                tweetResult.TotalNumberofTimesAnotherUserWasMentionedPerAccount.Add(account.Name, account.TotalNumberofTimesAnotherUserWasMentioned);

                foreach (var tweet in account.Tweets)
                {
                    tweets.Add(new Models.Tweet { DateAndTime = tweet.DateAndTime, Details = tweet.Details, Account = account.Name });
                }

            }

            var tweetsOrderedbyDate = tweets.OrderByDescending(x => x.DateAndTime);

            foreach (var tweet in tweetsOrderedbyDate)
            {
                tweetResult.Tweets.Add(tweet);
            }

            return tweetResult;
        }
    }

}