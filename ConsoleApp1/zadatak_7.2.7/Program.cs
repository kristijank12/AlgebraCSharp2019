using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string ponovi = "d";

            while (ponovi == "d")
            {
                int x = -1;
                Console.WriteLine("Unesite prirodan broj: ");
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                if (CheckProsti(x))
                {
                    Console.WriteLine("Broj {0} je prost.", x);
                }
                else
                {
                    Console.WriteLine("Broj {0} nije prost.", x);
                }

                Console.WriteLine("Želite li provjeriti idući broj? (D/N)");
                try
                {
                    ponovi = Console.ReadKey().KeyChar.ToString().ToLower();
                    if (ponovi != "d" && ponovi != "n")
                    {
                        throw new WrongChoiceException("Neispravan izbor!");
                    }
                    Console.WriteLine("\n");
                }
                catch (WrongChoiceException wcex)
                {
                    Console.WriteLine(wcex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.ReadKey();
        }

        static bool CheckProsti(int x)
        {
            bool prost = true;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
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
