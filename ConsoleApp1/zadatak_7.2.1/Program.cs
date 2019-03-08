using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            Console.WriteLine("Izaberite broj za varijablu koju unosite: " +
                "1. Radijus\n" +
                "2. Opseg\n" +
                "3. Površina");

            try
            {
                izbor = int.Parse(Console.ReadKey().KeyChar.ToString());
                if (izbor != 1 && izbor != 2 && izbor != 3)
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
                        Console.WriteLine("\nUnesite vrijednost radijusa:");
                        double radijus = double.Parse(Console.ReadLine());
                        Console.WriteLine("Opseg kruga s radijusom {0} je " +
                            "{1}.", radijus, Math.Round(Opseg(radijus), 2));
                        Console.WriteLine("Površina kruga s radijusom {0} je " +
                            "{1}.", radijus, Math.Round(Povrsina(radijus), 2));
                        break;
                    case 2:
                        Console.WriteLine("\nUnesite vrijednost Opsega:");
                        double opseg = double.Parse(Console.ReadLine());
                        Console.WriteLine("Radijus kruga s opsegom {0} je " +
                            "{1}.", opseg, Math.Round(RadijusOpseg(opseg), 2));
                        Console.WriteLine("Površina kruga s opsegom {0} je " +
                            "{1}.", opseg, 
                            Povrsina(Math.Round(RadijusOpseg(opseg), 2)));
                        break;
                    case 3:
                        Console.WriteLine("\nUnesite vrijednost Površine:");
                        double povrsina = double.Parse(Console.ReadLine());
                        Console.WriteLine("Radijus kruga povrsine {0} je " +
                            "{1}.", 
                            povrsina, Math.Round(RadijusPovrsina(povrsina), 2));
                        Console.WriteLine("Opseg kruga povrsine {0} je " +
                            "{1}.", povrsina, 
                            Povrsina(Math.Round(RadijusPovrsina(povrsina), 2)));
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

        static double Opseg(double r)
        {
            return 2 * r * Math.PI;
        }

        static double Povrsina(double r)
        {
            return r * r * Math.PI;
        }

        static double RadijusOpseg(double o)
        {
            return o / (2 * Math.PI);
        }

        static double RadijusPovrsina(double p)
        {
            return Math.Sqrt(p * Math.PI);
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
