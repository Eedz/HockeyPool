using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    public class UserBet
    {
        public int userid;
        public decimal amount;

        public UserBet (int user, decimal amt)
        {
            userid = user;
            amount = amt;
        }
    }
}
