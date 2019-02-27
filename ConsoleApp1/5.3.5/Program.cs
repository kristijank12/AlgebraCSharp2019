using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi s 3 iz intervala [3, 150} su;");
            for (int i = 3; i <= 150; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0},", i);

                }
            }
            Console.ReadKey();
        }
    }
}

