﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1._1.Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();
            Console.WriteLine("Unesi broj, za kraj unesi 0");
            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                arr.Add(broj);

            }
            // ispis
            foreach (int brojcic in arr) ;
            {
                Console.Write("");
            }
            Console.ReadKey();
        }

    }
}
