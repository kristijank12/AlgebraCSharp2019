using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj:");
            int a = int.Parse(Console.ReadLine());
            if (a >= 100)
            {
                Console.WriteLine("Broj je velik.");
            }
            else
            {
                Console.WriteLine("broj nije velik.");
            }
            Console.ReadKey();

        }
    }
}
