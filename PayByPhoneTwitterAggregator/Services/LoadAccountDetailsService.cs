using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator;
using PayByPhoneTwitterAggregator.Services.Interfaces;
using PayByPhoneTwitterAggregator.Entities.Interfaces;

/*
 * Populates the Account Entities with all their data. Retrieving and calculating data with helper services as needed.
 */

namespace PayByPhoneTwitterAggregator.Services
{
    public class LoadAccountDetailsService : ILoadAccountDetailsService
    {
        ITwitterAccessService twitterAccessService;
        ICalculateTweetAggregatesService calculateTweetAggregates;

        public LoadAccountDetailsService(ITwitterAccessService twitterAccessService, ICalculateTweetAggregatesService calculateTweetAggregates)
        {
            this.twitterAccessService = twitterAccessService;
            this.calculateTweetAggregates = calculateTweetAggregates;
        }

        public void PopulatedAccount(IAccount account, int days)
        {
            PopulateTweetsForLastTwoWeeks(account, days);
            account.TotalTweets = calculateTweetAggregates.CalculateTotalTweets(account);
            account.TotalNumberofTimesAnotherUserWasMentioned = 
                calculateTweetAggregates.CalculateTotalNumberofTimesAnotherUserWasMentioned(account);

        }

        private void PopulateTweetsForLastTwoWeeks(IAccount account, int days)
        {
            var searchResultList = twitterAccessService.GetTweets(account.Name, days);

            foreach (var result in searchResultList)
            {
                account.Tweets.Add(new Tweet { DateAndTime = result.CreatedDate, Details = result.Text, Mentions = result.Entities.Mentions.Count });
            }
        }
    }
}
