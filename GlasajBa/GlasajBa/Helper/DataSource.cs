using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Helper
{
    class DataSource
    {
        List<string> strucneSpreme, pozicije, priznanja, popularnosti;

        List<string> birackaMjesta;

        public DataSource()
        {
            StrucneSpreme = new List<string>();
            Pozicije = new List<string>();
            Priznanja = new List<string>();
            Popularnosti = new List<string>();
            StrucneSpreme.Add("NSS");
            StrucneSpreme.Add("SSS");
            StrucneSpreme.Add("VSS");
            Pozicije.Add("Predsjednik");
            Pozicije.Add("Clan");
            Priznanja.Add("Najbolji politicar");
            Popularnosti.Add("Nepopularan");
            Popularnosti.Add("Popularan");

            BirackaMjesta = new List<string>();
            BirackaMjesta.Add("BBI Centar, Trg djece Sarajeva 1");
            BirackaMjesta.Add("Shopping City Grabavica, Hasana Brkića 30");
        }

        public List<string> Popularnosti
        {
            get
            {
                return popularnosti;
            }

            set
            {
                popularnosti = value;
            }
        }

        public List<string> Pozicije
        {
            get
            {
                return pozicije;
            }

            set
            {
                pozicije = value;
            }
        }

        public List<string> Priznanja
        {
            get
            {
                return priznanja;
            }

            set
            {
                priznanja = value;
            }
        }

        public List<string> StrucneSpreme
        {
            get
            {
                return strucneSpreme;
            }

            set
            {
                strucneSpreme = value;
            }
        }

        public List<string> BirackaMjesta
        {
            get
            {
                return birackaMjesta;
            }

            set
            {
                birackaMjesta = value;
            }
        }
    }
}
