using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite x koordinatu točke P1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite y koordinatu točke P1: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite x koordinatu točke P2: ");
                double y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite y koordinatu točke P2: ");
                double y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Udaljenost unešenih točaka iznosi: {0}",
                    Math.Round(Udaljenost(x1, x2, y1, y2), 2));
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }

        static double Udaljenost(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + 
                ((y2 - y1) * (y2 - y1)));
        }
    }
}
