using GlasajBa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Helper
{
    class DataSource
    {

        #region Glasac - kreiranje testnih glasaca

        private static List<Glasac> _glasaci = new List<Glasac>()
        {
            new Glasac()
            {
                Ime = "Prvi",
                Prezime = "Korisnik",
                DatRodjenja = new DateTime(1980,2,2),
                LicnaKarta = "123456789",
                JMBG1 = "123456789120",
                DrzavaBoravka = "BiH",
                JeLiGlasao = false, 
                NaBirackomMjestu = false
            },
            new Glasac()
            {
                Ime = "Drugi",
                Prezime = "Korisnik",
                DatRodjenja = new DateTime(1970,2,2),
                LicnaKarta = "123456788",
                JMBG1 = "123456789121",
                DrzavaBoravka = "BiH",
                JeLiGlasao = false,
                NaBirackomMjestu = false
            }
        };
        public static IList<Glasac> DajSveGlasace()
        {
            return _glasaci;
        }
        #endregion

        #region GlasackiSistem - kreiranje tesnog sistema

        private static List<GlasackiSistem> _glasackiSitem = new List<GlasackiSistem>()
        {
            new GlasackiSistem()
            {
                Glasaci = (List<Glasac>)DajSveGlasace(),
                KandidatiO = new List<Kandidat>(),
                KandidatiK = new List<Kandidat>(),
                KandidatiE = new List<Kandidat>(),
                KandidatiD = (List<Kandidat>)DajSveKandidate(),
                Stranke = new List<Stranka>(),
                Ulice = new List<Ulica>(),
                Novosti = new List<Novost>(),
                Pocetak = new DateTime(2017,6,6),
                Kraj = new DateTime(2017,6,7),
                LokalniIzbori = false,
                AdminPassword = "mrviceljubavi",
                AdminUsername = "ooad",
                Slijepi = false
            }
        };
        public static IList<GlasackiSistem> DajSveGlasackeSisteme()
        {
            return _glasackiSitem;
        }

        #endregion

        #region Stranke 

        public static IList<Stranka> _stranke = new List<Stranka>()
        {
            new Stranka()
            {
                Naziv = "NNH",
                Ukratko = "Najbolja stranka"
            }
        };
        public static IList<Stranka> DajSveStranke()
        {
            return _stranke;
        }

        #endregion

        #region Kandidati - kreiranje testnih kandidata

        public static IList<Kandidat> _kandidati = new List<Kandidat>()
        {
            new Kandidat()
            {
                Ime = "Kandidat",
                Prezime = "Kandidovski",
                DatRodjenja = new DateTime(1940,6,6),
                LicnaKarta = "1478523697",
                JMBG1 = "789456123123",
                DrustvenaPriznanja = "",
                DrzavaBoravka = "BiH",
                Godine = DateTime.Now.Year - 1940,
                Stranka = DajSveStranke()[0],
                StrucnaSprema = "VSS",
                Pozicija = "predsjednik",
                Slika = null,
                Popularnost = 1
            }
        };

        public static IList<Kandidat> DajSveKandidate()
        {
            return _kandidati;
        }
        #endregion

        #region Ulice
        private static IList<Ulica> _ulice = new List<Ulica>()
        {
            new Ulica()
            {
                Naziv = "Maršala Tita",
                BirackoMjesto = "BBI Centar, Trg djece Sarajeva 1"
            }
        };

        public static IList<Ulica> DajSveUlice()
        {
            return _ulice;
        }
        #endregion

        #region Novosti
        private static IList<Novost> _novosti = new List<Novost>()
        {
            new Novost()
            {
                Naslov = "Prva novost",
                Tekst = "Ovo je prva novost",
                Slike = null,
                DatumObjave = DateTime.Now
            }
        };

        public static IList<Novost> DajSveNovosti()
        {
            return _novosti;
        }

        #endregion

        public DataSource()
        {
            Glasac g1 = DajSveGlasace()[0];
            GlasackiSistem gs1= DajSveGlasackeSisteme()[0];
            Stranka s1 = DajSveStranke()[0];
            Ulica u1 = DajSveUlice()[0];
            Novost n1 = DajSveNovosti()[0];
        }

        #region komentirano
        /*
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
    }*/
        #endregion
    }
}
