using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    public class Person
    {
        int id;
        string name;
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

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
