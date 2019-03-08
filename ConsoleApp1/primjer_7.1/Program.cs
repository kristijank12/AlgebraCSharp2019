using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Console.WriteLine(HelloWorld("olaa"));
            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static String HelloWorld(String poz)
        {
            return poz + " i tebi oj putniče!";
        }
    }
}
