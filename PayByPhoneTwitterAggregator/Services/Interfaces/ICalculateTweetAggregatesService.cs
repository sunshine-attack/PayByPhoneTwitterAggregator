using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    public interface ICalculateTweetAggregatesService
    {
           int CalculateTotalTweets(IAccount account);
           int CalculateTotalNumberofTimesAnotherUserWasMentioned(IAccount account);
    }
}
