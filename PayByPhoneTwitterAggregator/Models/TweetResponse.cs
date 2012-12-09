using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayByPhoneTwitterAggregator.Models
{

    public class TweetResponse
    {
        public TweetResponse()
        {
            TotalTweetsPerAccount = new Dictionary<String, int>();
            TotalNumberofTimesAnotherUserWasMentionedPerAccount = new Dictionary<string, int>();
            Tweets = new List<Tweet>();
        }

       public List<Tweet> Tweets { get; set; }
       public Dictionary<String, int> TotalTweetsPerAccount { get; set; }
       public Dictionary<String, int> TotalNumberofTimesAnotherUserWasMentionedPerAccount { get; set; }
    }

    public class Tweet
    {
        public DateTime DateAndTime { get; set; }
        public String Account { get; set; }
        public String Details { get; set; }
    }

}