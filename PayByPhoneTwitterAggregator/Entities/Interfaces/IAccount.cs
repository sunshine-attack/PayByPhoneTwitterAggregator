using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface IAccount
    {
        public String Name { get; set; }
        public List<Tweet> Tweets { get; set; }
        public int TotalTweets{ get; set; }
        public int TotalNumberofTimesAnotherUserWasMentioned{ get; set; }
    }
}
