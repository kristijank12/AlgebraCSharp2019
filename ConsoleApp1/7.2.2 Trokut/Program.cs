using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2_Trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi povrsinu trokuta: ");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("unesi duljinu prve katete: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("duljina druge katete jednakokracnog trokuta je {0}.", KatetaB(p, a));
            Console.ReadLine();
        }
        static double KatetaB(double p, double a)
        {
            return (2 * p) / a;
        }
    }
}
        
    

