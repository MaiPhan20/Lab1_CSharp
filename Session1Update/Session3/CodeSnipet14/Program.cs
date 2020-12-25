using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exist between 1 and 10");
            }
        }
    }
}
