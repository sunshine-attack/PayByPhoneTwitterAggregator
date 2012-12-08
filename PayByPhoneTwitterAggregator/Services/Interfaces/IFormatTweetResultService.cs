using PayByPhoneTwitterAggregator.Entities;
using PayByPhoneTwitterAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    public interface IFormatTweetResultService
    {
        TweetResult CreateTweetResult(List<Account> accounts);
    }
}
