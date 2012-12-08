using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface ITweet
    {
         DateTime DateAndTime { get; set; }
         String Details { get; set; }
         String User { get; set; }
    }
}
