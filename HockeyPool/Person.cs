using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    class Person
    {
        String name;
        double balance;
        List<Game> games;

        public Person()
        {
            name = "";
            balance = 0;
            games = null;
        }

        public Person (String n, double b)
        {
            name = n;
            balance = b;
        }
    }
}
