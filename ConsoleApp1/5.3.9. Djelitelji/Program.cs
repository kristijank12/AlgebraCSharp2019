using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._9.Djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Djelitelji broja {0} su:", a);

            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();
        }
    }
}
