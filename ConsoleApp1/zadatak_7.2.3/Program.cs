using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            Console.WriteLine("1. KS u KW\n" +
                "2. KW u KS\n");

            try
            {
                izbor = int.Parse(Console.ReadKey().KeyChar.ToString());
                if (izbor != 1 && izbor != 2)
                {
                    throw new WrongChoiceException("Neispravan izbor!");
                }
            }
            catch (WrongChoiceException wcex)
            {
                Console.WriteLine(wcex.ToString());
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("\nUnesite vrijednost KS:");
                        double ks = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0}KS je {1}KW", 
                            ks, Math.Round(CalculateKSToKW(ks), 2));
                        break;
                    case 2:
                        Console.WriteLine("\nUnesite vrijednost KW:");
                        double kw = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0}KS je {1}KW",
                            kw, Math.Round(CalculateKWToKS(kw), 2));
                        break;
                    default:
                        break;
                }
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

        static double CalculateKSToKW(double ks)
        {
            return ks * 0.736;
        }

        static double CalculateKWToKS(double ks)
        {
            return ks / 0.736;
        }

        public class WrongChoiceException : Exception
        {
            public WrongChoiceException()
            {
            }

            public WrongChoiceException(string message)
                : base(message)
            {
            }

            public WrongChoiceException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}
