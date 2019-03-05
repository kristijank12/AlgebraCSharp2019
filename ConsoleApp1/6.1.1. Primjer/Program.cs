using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1.Primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija
            int[] niz = new int[3];

            //int
            niz[0] = 55;
            niz[2] = 77;
            niz[1] = 22;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == null)

                {
                    throw new Exception("Niz sadrži ne iinicijaliziranu vrijednost na indexu");

                }
                Console.WriteLine((i+1)+"index");

                Console.WriteLine((i + 1) +":" + niz[i]);
                Console.ReadKey();
            }


        
        }
    }
}
