using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            Console.WriteLine("1. °C u °F\n" +
                "2. °F u °C\n");

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
                        Console.WriteLine("\nUnesite vrijednost u °C:");
                        double cel = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0}°C je {1}°F",
                            cel, Math.Round(CalculateCelToFah(cel), 2));
                        break;
                    case 2:
                        Console.WriteLine("\nUnesite vrijednost u °F:");
                        double fah = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0}°F je {1}°C",
                            fah, Math.Round(CalculateFahToCel(fah), 2));
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

        static double CalculateCelToFah(double cel)
        {
            return cel * 9 / 5 + 32;
        }

        static double CalculateFahToCel(double fah)
        {
            return (fah - 32) * 5 / 9;
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

