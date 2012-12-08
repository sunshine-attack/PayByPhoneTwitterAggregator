using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface IAccount
    {
         String Name { get; set; }
         List<Tweet> Tweets { get; set; }
         int TotalTweets{ get; set; }
         int TotalNumberofTimesAnotherUserWasMentioned{ get; set; }
    }
}
