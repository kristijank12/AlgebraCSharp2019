using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _6._2._3.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();
            Console.WriteLine("Unesite elemente niza:");
            while (broj != 0) ;
            {
                broj = int.Parse(Console.ReadLine());
                arr.Add(broj);



            }
            arr.Sort();
            Console.WriteLine("Ispis");
            foreach (int a in arr)
            {
                Console.WriteLine(a);

            }
            Console.ReadKey();

        }
    }
}
