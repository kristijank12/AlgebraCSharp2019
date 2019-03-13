using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_1_Dogadjaji
{
    public class Osoba
    {
        //Deklaracija dogadjaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        //Svojstva
        private string ime;
        public string Ime

        {
            get { return ime; }
            set
            {
                ime = value;
                if(NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }             
            }
        }
    }
}
