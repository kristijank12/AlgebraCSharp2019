using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2.Pozdrav
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozdrav("Đuro");
            Pozdrav("Đuro", "Đurić");
            Console.ReadKey();
        }
        static void Pozdrav(string ime)
        {
            Console.WriteLine("Dobar dan," + ime + "!");

        }
        static void Pozdrav(string ime, string prezime)
        {
            Console.WriteLine("Dobar dan," + ime + " " + prezime + "!");                          
        }
    }
}
