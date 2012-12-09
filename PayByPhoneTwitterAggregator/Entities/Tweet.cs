using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayByPhoneTwitterAggregator.Entities.Interfaces;

namespace PayByPhoneTwitterAggregator.Entities
{
    public class Tweet:ITweet
    {
        public DateTime DateAndTime { get; set; }
        public String Details { get; set; }
        public int Mentions { get; set; }
    }
}
