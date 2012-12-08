using PayByPhoneTwitterAggregator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    public interface ICalculateTweetAggregates
    {
           void CalculateTotalTweets(ref Account account);
           void CalculateTotalNumberofTimesAnotherUserWasMentioned(ref Account account);
    }
}
