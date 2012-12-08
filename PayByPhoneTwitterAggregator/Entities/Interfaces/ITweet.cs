using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Entities.Interfaces
{
    interface ITweet
    {
        public DateTime DateAndTime { get; set; }
        public String Details { get; set; }
        public String User { get; set; }
    }
}
