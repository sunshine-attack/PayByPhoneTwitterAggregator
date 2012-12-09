using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    public interface ITwitterAccessService
    {
        List<TwitterStatus> GetTweetsForLastTwoWeeks(String account);
        List<TwitterStatus> GetTweets(String account, int days);
    }
}
