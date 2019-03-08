using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Unesite prirodan broj: ");
            try
            {
                x = int.Parse(Console.ReadLine());

                if (x < 0)
                {
                    throw new NegativeNumberException("Mora biti pozitivan!");
                }

                Console.WriteLine("Faktorijel od {0} iznosi {1}!", x, Faktorijel(x));
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

        static double Faktorijel(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                double fak = 1;

                for (int i = 1; i <= x; i++)
                {
                    fak *= i;
                }

                return fak;
            }
        }

        public class NegativeNumberException : Exception
        {
            public NegativeNumberException()
            {
            }

            public NegativeNumberException(string message)
                : base(message)
            {
            }

            public NegativeNumberException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}
