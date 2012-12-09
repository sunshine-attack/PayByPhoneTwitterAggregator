using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PayByPhoneTwitterAggregator.Entities;
using TwitterAccess;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using PayByPhoneTwitterAggregator.Entities.Interfaces;

namespace PayByPhoneTwitterAggregator.Services
{
    public class LoadAccountDetailsService : ILoadAccountDetailsService
    {
        TwitterAccessService twitterAccessService;
        CalculateTweetAggregates calculateTweetAggregates;

        public LoadAccountDetailsService(TwitterAccessService twitterAccessService)
        {
            this.twitterAccessService = twitterAccessService;
            calculateTweetAggregates = new CalculateTweetAggregates();
        }

        public void PopulatedAccount(IAccount account)
        {
            PopulateTweetsForLastTwoWeeks(account);
            account.TotalTweets = calculateTweetAggregates.CalculateTotalTweets(account);
            account.TotalNumberofTimesAnotherUserWasMentioned = 
                calculateTweetAggregates.CalculateTotalNumberofTimesAnotherUserWasMentioned(account);

        }

        private void PopulateTweetsForLastTwoWeeks(IAccount account)
        {
            var searchResultList = twitterAccessService.GetTweetsForLastTwoWeeks(account.Name);

            foreach (var result in searchResultList)
            {
                account.Tweets.Add(new Tweet { DateAndTime = result.CreatedDate, Details = result.Text, Mentions = result.Entities.Mentions.Count });
            }
        }
    }
}
