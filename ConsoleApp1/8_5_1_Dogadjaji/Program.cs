using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_1_Dogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba_ = new Osoba();
            osoba_.NaPromjenuImena += new
                Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
            Console.ReadKey();

        }

        private static void osoba_NaPromjenuImena(object sender, EventArgs e)
        {
            Console.WriteLine("Osoba je promijenila podatke: {0}",
                ((Osoba)sender).Ime);
        }
    }
}
