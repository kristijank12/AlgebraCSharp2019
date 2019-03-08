using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_7._2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList brojevi = Unos();
            Console.WriteLine("Ispis neparnih:");
            Ispis(Neparni(brojevi));

            Console.WriteLine("Ispis parnih:");
            Ispis(Parni(brojevi));

            Console.ReadKey();
        }

        static ArrayList Unos()
        {
            int i = 0;
            ArrayList brojevi = new ArrayList();

            while (true)
            {
                i++;
                Console.WriteLine("Unesite {0}. broj:", i);
                int broj = int.Parse(Console.ReadLine());

                if (broj == 0)
                {
                    break;
                }

                brojevi.Add(broj);
            }

            return brojevi;
        }

        static void Ispis(ArrayList brojevi)
        {
            foreach (int x in brojevi)
            {
                Console.WriteLine(x);
            }
        }
        static ArrayList Neparni(ArrayList brojevi)
        {
            ArrayList neparni = new ArrayList();
            foreach (int n in brojevi)
            {
                if (n % 2 != 0)
                {
                    neparni.Add(n);
                }
            }
            return neparni;
        }
        static ArrayList Parni(ArrayList brojevi)
        {
            for (int i = brojevi.Count - 1; i >= 0; i--)
            {
                if ((int)brojevi[i] % 2 != 0)
                {
                    brojevi.RemoveAt(i);
                }
            }
            return brojevi;
        }
    }
}
