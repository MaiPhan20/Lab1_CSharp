using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet18
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 100; 
            uint result = num << 1;
            Console.WriteLine("Value before left shift: " +num);
            Console.WriteLine("Value after left shift " +result);
            num = 80; 
            result = num >> 1; 
            Console.WriteLine("\nValue before right shift: " +num);
            Console.WriteLine("Value after right shift: " +result);
        }
    }
 }

