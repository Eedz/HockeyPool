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
        
        public Person()
        {
            name = "";
            balance = 0;
        
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
