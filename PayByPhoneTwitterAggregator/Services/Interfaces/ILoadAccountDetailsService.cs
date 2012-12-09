using PayByPhoneTwitterAggregator.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayByPhoneTwitterAggregator.Services.Interfaces
{
    public interface ILoadAccountDetailsService
    {
        void PopulatedAccount(IAccount account, int days);
    }
}
