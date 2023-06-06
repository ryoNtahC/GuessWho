using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesswho
{
    internal class Panacik
    {
        private string meno;
        private string pohlavie;
        private string vlasy;
        private string oci;
        private string pokryvka;
        private string doplnok;
        private string fuzy;

        public Panacik(string meno, string pohlavie, string vlasy, string oci, string pokryvka, string doplnok, string fuzy)
        {
            this.meno = meno;
            this.pohlavie = pohlavie;
            this.vlasy = vlasy;
            this.oci = oci;
            this.pokryvka = pokryvka;
            this.doplnok = doplnok;
            this.fuzy = fuzy;
        }

        public string Meno { get => meno; set => meno = value; }
        public string Pohlavie { get => pohlavie; set => pohlavie = value; }
        public string Vlasy { get => vlasy; set => vlasy = value; }
        public string Oci { get => oci; set => oci = value; }
        public string Pokryvka { get => pokryvka; set => pokryvka = value; }
        public string Doplnok { get => doplnok; set => doplnok = value; }
        public string Fuzy { get => fuzy; set => fuzy = value; }
    }
}
