﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet24
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 4.5F;
            double circumference;
            circumference = 2 * 3.14 * radius;
            object boxed = (object)circumference;
            Console.WriteLine("Circum ference of the circle = {0}", circumference);
        }
    }
}
