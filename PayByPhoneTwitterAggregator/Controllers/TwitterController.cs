using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PayByPhoneTwitterAggregator.Models;
using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Services;
using PayByPhoneTwitterAggregator;
using PayByPhoneTwitterAggregator.Entities.Interfaces;


/*
 * The TwitterControllerManages handles the requests for twitter information and delegates resposiblity to several services
 * in order to carry out its duties.
 * 
 * The web service backing model, TweetResponse, contains the implementation specific definition for providing a response.
 * 
 * The business model data is stored in the aggregate entity, Account. This entity and its aggregate parts 
 * manage the details associated with the twitter feed accounts.
 * 
 * The Account Entities are managed bv the AccountManagerService, which acts as a repository.
 * 
 */

namespace PayByPhoneTwitterAggregator.Controllers
{

    public class TwitterController : ApiController
    {
        LoadAccountDetailsService loadAccountDetailsService;
        TwitterAccessService twitterAccessService;
        AccountManagerService accountManager;
        FormatTweetResultService twitterResultService;
        TweetResponse tweetResult;
        List<IAccount> accounts;
        CalculateTweetAggregatesService calculateTweetAggregates; 

        public TwitterController()
        {
            twitterAccessService = new TwitterAccessService();
            calculateTweetAggregates = new CalculateTweetAggregatesService();
            loadAccountDetailsService = new LoadAccountDetailsService(twitterAccessService, calculateTweetAggregates);

            accountManager = new AccountManagerService(loadAccountDetailsService);

        }

        [HttpGet]
        public TweetResponse TwitterFeed()
        {
            return TwitterFeedByDays(14);
        }

        [HttpGet]
        public TweetResponse TwitterFeedByDays(int id = 0)
        {
            var days = id;

            accountManager.CreateAccount("pay_by_phone", days);
            accountManager.CreateAccount("PayByPhone", days);
            accountManager.CreateAccount("PayByPhone_UK", days);

            accounts = accountManager.GetAccounts();
            twitterResultService = new FormatTweetResultService();
            tweetResult = twitterResultService.CreateTweetResult(accounts);

            return tweetResult;
        }

    }
}


