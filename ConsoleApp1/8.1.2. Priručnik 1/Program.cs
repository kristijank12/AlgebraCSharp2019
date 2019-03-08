using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2.Priručnik_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciraj novi objekt klae Ucenik
            Ucenik uc1 = new Ucenik();
            //inicijalizacija objekta
            Console.WriteLine("Unesi ime učenika:");
            
            uc1.ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime učenika");
            Console.WriteLine("Unesi ocjenu iz matematike:");
            Console.WriteLine("Unesi ocjenu iz biologije:");
            Console.WriteLine("Unesi ocjenu iz engleskog:");

            //instanciraj novi object klase Ucenik
            Ucenik uc2 = new Ucenik("Perica");
            Console.WriteLine("Unesi ime učenika je" + uc1.ime + "i" + uc2.ime);
            List<Ucenik> ucenici = new List<Ucenik>();
            ucenici.Add(uc1);
            ucenici.Add(uc2);
            //ucenici.Add({uc1, uc2});
            foreach (var item in ucenici)
            {
                Console.WriteLine(item.ime);
            }
            Console.ReadKey();

        }
    }
}
