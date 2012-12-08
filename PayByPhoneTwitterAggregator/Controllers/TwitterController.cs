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
using TwitterAccess;

namespace PayByPhoneTwitterAggregator.Controllers
{

    public class TwitterController : ApiController
    {
     
        LoadAccountDetailsService accountDetailsService;
        TwitterAccessService twitterAccessService;
        AccountManager accountManager;
        FormatTweetResultService twitterResultService;
        TweetResult tweetResult;
        List<Account> accounts; 

        public TwitterController()
        {
            twitterAccessService = new TwitterAccessService();
            accountDetailsService = new LoadAccountDetailsService(twitterAccessService);

            accountManager = new AccountManager(accountDetailsService);
            accountManager.CreateAccount("pay_by_phone");
            accountManager.CreateAccount("PayByPhone");
            accountManager.CreateAccount("PayByPhone_UK");

            twitterResultService = new FormatTweetResultService();
            accounts = accountManager.GetAccounts();
            tweetResult = twitterResultService.CreateTweetResult(accounts);
        }

        public TweetResult GetTwitterFeed()
        {
            return tweetResult;
        }

    }
}


