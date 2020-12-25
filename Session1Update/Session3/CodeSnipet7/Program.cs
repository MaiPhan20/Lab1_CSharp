using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet7
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 2500;
            int price = 10;
            if ((quantity > 2000) | (price < 10.5))
            {
                Console.WriteLine("You can buy more goods at a lower price");
            }
        }
    }
}
