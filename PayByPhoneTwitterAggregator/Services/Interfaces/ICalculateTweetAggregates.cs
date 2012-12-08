using PayByPhoneTwitterAggregator.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    interface ICalculateTweetAggregates
    {
         public void CalculateTotalTweets(ref IAccount account);
         public void CalculateTotalNumberofTimesAnotherUserWasMentioned(ref IAccount account);
    }
}
