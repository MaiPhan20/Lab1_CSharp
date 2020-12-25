using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet10
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 2000;
            double price = 10.5;
            if ((quantity == 2000) ^ (price == 10.5))
            {
                Console.WriteLine("You have to compromise between quantity and price");
            }
        }
    }
}

