using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Klase
{
    class GlasackiSistem
    {
        List<Glasac> glasaci;
        List<Kandidat> kandidati;
        List<Stranka> stranke;
        List<Ulica> ulice;
        List<Novost> novosti;
        DateTime pocetak, kraj;
        bool lokalniIzbori;

        string adminPassword, adminUsername;
        bool slijepi;


        string nadjiBiracko(string ul)
        {
            foreach (Ulica u in ulice)
                if (ul == u.Naziv)
                    return u.BirackoMjesto;
            return "Greska! Nema date ulice!";
        }

        bool registrujAdmina(string un, string pass)
        {
            if (un == AdminUsername && pass == AdminPassword)
                return true;
            return false;
        }

        public GlasackiSistem(List<Glasac> glasaci, List<Kandidat> kandidati, List<Stranka> stranke, List<Ulica> ulice, List<Novost> novosti, DateTime pocetak, DateTime kraj, bool lokalniIzbori, string adminPassword, string adminUsername, bool slijepi)
        {
            this.glasaci = glasaci;
            this.kandidati = kandidati;
            this.stranke = stranke;
            this.ulice = ulice;
            this.novosti = novosti;
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.lokalniIzbori = lokalniIzbori;
            this.adminPassword = adminPassword;
            this.adminUsername = adminUsername;
            this.slijepi = slijepi;
        }

        public List<Glasac> Glasaci
        {
            get
            {
                return glasaci;
            }

            set
            {
                glasaci = value;
            }
        }

        public List<Kandidat> Kandidati
        {
            get
            {
                return kandidati;
            }

            set
            {
                kandidati = value;
            }
        }

        public List<Stranka> Stranke
        {
            get
            {
                return stranke;
            }

            set
            {
                stranke = value;
            }
        }

        public List<Ulica> Ulice
        {
            get
            {
                return ulice;
            }

            set
            {
                ulice = value;
            }
        }

        public List<Novost> Novosti
        {
            get
            {
                return novosti;
            }

            set
            {
                novosti = value;
            }
        }

        public DateTime Pocetak
        {
            get
            {
                return pocetak;
            }

            set
            {
                pocetak = value;
            }
        }

        public DateTime Kraj
        {
            get
            {
                return kraj;
            }

            set
            {
                kraj = value;
            }
        }

        public bool LokalniIzbori
        {
            get
            {
                return lokalniIzbori;
            }

            set
            {
                lokalniIzbori = value;
            }
        }

        public string AdminPassword
        {
            get
            {
                return adminPassword;
            }

            set
            {
                adminPassword = value;
            }
        }

        public string AdminUsername
        {
            get
            {
                return adminUsername;
            }

            set
            {
                adminUsername = value;
            }
        }

        public bool Slijepi
        {
            get
            {
                return slijepi;
            }

            set
            {
                slijepi = value;
            }
        }
    }
}
