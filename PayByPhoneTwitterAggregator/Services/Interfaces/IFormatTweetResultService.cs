using PayByPhoneTwitterAggregator.Entities.Interfaces;
using PayByPhoneTwitterAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    interface IFormatTweetResultService
    {
        public TweetResult CreateTweetResult(List<IAccount> accounts);
    }
}
