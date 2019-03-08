using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            static double Udaljenost(int x1, int y1, int x2, int y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }

            static void Main(string[] args)
            {
                Console.Write(Udaljenost(0, 0, 1, 1));
                Console.Read();
            }
        }
    }
}
    

