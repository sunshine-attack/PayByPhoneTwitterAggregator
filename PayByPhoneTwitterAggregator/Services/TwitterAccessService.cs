using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;



namespace TwitterAccess
{
        public class TwitterAccessService
        {
            OAuthRequestToken token;
            TwitterService service;

            public TwitterAccessService()
            {

                var ConsumerKey = "XYibQ9TLaR9ygaOSk5kqew";
                var ConsumerSecret = "nULuAiTRU9hpPx5PbjyNbU36kilcNZ5vKhgMdJFx2A";
                var AccessToken = "105040957-NGNdU4VzIZLhxcuABIq3AS5BfmVTuO8Ai8srcZmI";
                var AccessTokenSecret = "d2s6kIXSE9GcK31bSjTR6QGElgtbUJitGPP8uP1k5pY";

                // Pass your credentials to the service
                service = new TwitterService(ConsumerKey, ConsumerSecret);

                //Retrieve an OAuth Request Token
                token = service.GetRequestToken();

                //Authenticates using the Access Token
                service.AuthenticateWith(AccessToken, AccessTokenSecret);
               
            }

            public List<TwitterStatus> GetTweetsForLastTwoWeeks(String account)
            {

                var twitterStatuses = new List<TwitterStatus>();
                var pageNumber = 1;
                var moreResults = true;
                IEnumerable<TwitterStatus> tweets;

                tweets = service.ListTweetsOnSpecifiedUserTimeline(account, pageNumber, 20);

                while (service.Response.StatusCode == HttpStatusCode.OK && moreResults)
                {
                    
                    var tweetsLimited = tweets.Where(x => x.CreatedDate > DateTime.Now.AddDays(-14));

                    if (tweetsLimited.Count() > 0)
                    {
                        twitterStatuses.AddRange(tweetsLimited.ToList());
                        pageNumber++;;
                        tweets = service.ListTweetsOnSpecifiedUserTimeline(account, pageNumber, 20);
                    }
                    else
                    {
                        moreResults = false;
                    }

                }

                return twitterStatuses;
            }

        }
    }

