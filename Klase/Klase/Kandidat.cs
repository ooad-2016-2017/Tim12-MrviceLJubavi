using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Kandidat : Osoba
    {
        Stranka stranka;
        int godine;
        string strucnaSprema, pozicija, drustvenaPriznanja;
        int popularnost;

        public Stranka Stranka
        {
            get
            {
                return stranka;
            }

            set
            {
                stranka = value;
            }
        }

        public int Godine
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - DatRodjenja.Year;
                godine = age;
                return age;
            }

            set
            {
                //godine = value; nije moguce mijenjati godine starosti
            }
        }

        public string StrucnaSprema
        {
            get
            {
                return strucnaSprema;
            }

            set
            {
                strucnaSprema = value;
            }
        }

        public string Pozicija
        {
            get
            {
                return pozicija;
            }

            set
            {
                pozicija = value;
            }
        }

        public string DrustvenaPriznanja
        {
            get
            {
                return drustvenaPriznanja;
            }

            set
            {
                drustvenaPriznanja = value;
            }
        }

        public int Popularnost
        {
            get
            {
                return popularnost;
            }

            set
            {
                popularnost = value;
            }
        }

        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava) : base(im, prez, datR, LK, maticni, drzava)
        {        }

        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava, Stranka stranka, int godine, string strucnaSprema, string pozicija, string drustvenaPriznanja, int popularnost) : base(im, prez, datR, LK, maticni, drzava)
        {
            this.stranka = stranka;
            this.godine = godine;
            this.strucnaSprema = strucnaSprema;
            this.pozicija = pozicija;
            this.drustvenaPriznanja = drustvenaPriznanja;
            this.popularnost = popularnost;
        }




    }
}
