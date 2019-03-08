using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double prosjek = 0;

            Console.WriteLine("Vaš prosjek je: ");

            try
            {
                prosjek = double.Parse(Console.ReadLine());
                if (prosjek < 1 || prosjek > 5)
                {
                    throw new WrongIntervalException("Prosjek ocjena mora biti između 1 i 5");
                }

                Console.WriteLine("Prosjek je {0}!", Prosjek(prosjek));
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

        static string Prosjek(double prosjek)
        {
            string zakljucak = "";

            if (prosjek < 2)
            {
                zakljucak = "nedovoljan";
            }
            else if (prosjek < 2.5)
            {
                zakljucak = "dovoljan";
            }
            else if (prosjek < 3.5)
            {
                zakljucak = "dobar";
            }
            else if (prosjek < 4.5)
            {
                zakljucak = "vrlo dobar";
            }
            else
            {
                zakljucak = "odličan";
            }

            return zakljucak;
        }

        public class WrongIntervalException : Exception
        {
            public WrongIntervalException()
            {
            }

            public WrongIntervalException(string message)
                : base(message)
            {
            }

            public WrongIntervalException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}
