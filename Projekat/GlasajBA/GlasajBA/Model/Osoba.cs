using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Model
{
    public class Osoba
    {
        string ime, prezime;
        DateTime datRodjenja;
        string licnaKarta;
        string JMBG;
        string drzavaBoravka;

        public Osoba(string im, string prez, DateTime datR, string LK, string maticni, string drzava)
        {
            Ime = im;
            Prezime = prez;
            DatRodjenja = datR;
            LicnaKarta = LK;
            JMBG1 = maticni;
            DrzavaBoravka = drzava;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public DateTime DatRodjenja
        {
            get
            {
                return datRodjenja;
            }

            set
            {
                datRodjenja = value;
            }
        }

        public string LicnaKarta
        {
            get
            {
                return licnaKarta;
            }

            set
            {
                licnaKarta = value;
            }
        }

        public string JMBG1
        {
            get
            {
                return JMBG;
            }

            set
            {
                JMBG = value;
            }
        }

        public string DrzavaBoravka
        {
            get
            {
                return drzavaBoravka;
            }

            set
            {
                drzavaBoravka = value;
            }
        }
    }
}
