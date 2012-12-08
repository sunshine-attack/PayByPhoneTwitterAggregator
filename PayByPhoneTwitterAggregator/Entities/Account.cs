using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayByPhoneTwitterAggregator.Entities.Interfaces;

namespace PayByPhoneTwitterAggregator.Entities
{
    public class Account:IAccount
    {
        public String Name { get; set; }
        public List<Tweet> Tweets { get; set; }
        public int TotalTweets{ get; set; }
        public int TotalNumberofTimesAnotherUserWasMentioned{ get; set; }

        public Account(String name)
        {
            this.Name = name;
            Tweets = new List<Tweet>();
        }
    }
}