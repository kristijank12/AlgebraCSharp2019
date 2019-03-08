using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            Console.WriteLine("Želite li izračunati površinu trokuta ili " +
                "katetu (izaberite broj)?\n" +
                "1. Površina\n" +
                "2. Kateta\n");

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
                        Console.WriteLine("\nUnesite vrijednost prve katete:");
                        double x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nUnesite vrijednost druge katete:");
                        double y = double.Parse(Console.ReadLine());
                        Console.WriteLine("Površina trokuta s katetama {0} i " +
                            "{1} iznosi {2}.", x, y, Math.Round(Povrsina(x, y), 2));
                        break;
                    case 2:
                        Console.WriteLine("\nUnesite vrijednost prve katete:");
                        double n = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nUnesite vrijednost površine:");
                        double p = double.Parse(Console.ReadLine());
                        Console.WriteLine("Druga kateta trokuta površine {0} i " +
                            "jedne katete {1} iznosi {2}.", 
                            p, n, Math.Round(Kateta(p, n), 2));
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

        static double Povrsina(double a, double b)
        {
            return (a * b) / 2;
        }

        static double Kateta(double p, double a)
        {
            return 2 * p / a;
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
