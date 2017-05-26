using GlasajBa.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;

namespace GlasajBa.Model
{
    class GlasackiSistem
    {
        #region Atributi
        List<Glasac> glasaci;
        List<Kandidat> kandidatiOpcina;
        List<Kandidat> kandidatiKanton;
        List<Kandidat> kandidatiEntitet;
        List<Kandidat> kandidatiDrzava;
        List<Stranka> stranke;
        List<Ulica> ulice;
        List<Novost> novosti;
        DateTime pocetak, kraj;
        DataSource podaci;
        bool lokalniIzbori;
        string adminPassword, adminUsername;
        public static bool slijepi;
        #endregion

        #region Konstruktor
        public GlasackiSistem(List<Glasac> glasaci, List<Kandidat> kandidatiO, List<Kandidat> kandidatiK, List<Kandidat> kandidatiE, List<Kandidat> kandidatiD, List<Stranka> stranke, List<Ulica> ulice, List<Novost> novosti, DateTime pocetak, DateTime kraj, bool lokalniIzbori, string adminPassword, string adminUsername, bool slijepi)
        {
            this.glasaci = glasaci;
            this.kandidatiOpcina = kandidatiO;
            this.kandidatiOpcina = kandidatiK;
            this.kandidatiOpcina = kandidatiE;
            this.kandidatiOpcina = kandidatiD;
            this.stranke = stranke;
            this.ulice = ulice;
            this.novosti = novosti;
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.lokalniIzbori = lokalniIzbori;
            this.adminPassword = adminPassword;
            this.adminUsername = adminUsername;
            this.slijepi = slijepi;
            MediaPlayer mp = new MediaPlayer();
            pustiZvuk();
        }

        private async void pustiZvuk()
        {
            //ovo ce trebati biti implementirano negdje drugo
            MediaElement me = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Uvod.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            me.SetSource(stream, file.ContentType);
            me.Play();
        }
        #endregion

        #region GeteriISeteri
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

        public List<Kandidat> KandidatiO
        {
            get
            {
                return kandidatiOpcina;
            }

            set
            {
                kandidatiOpcina = value;
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

        public List<Kandidat> KandidatiK
        {
            get
            {
                return kandidatiKanton;
            }
            set
            {
                kandidatiKanton = value;
            }
        }
        public List<Kandidat> KandidatiE
        {
            get
            {
                return kandidatiEntitet;
            }
            set
            {
                kandidatiEntitet = value;
            }
        }
        public List<Kandidat> KandidatiD
        {
            get
            {
                return kandidatiDrzava;
            }
            set
            {
                kandidatiDrzava = value;
            }
        }
        internal DataSource Podaci
        {
            get
            {
                return podaci;
            }
            set
            {
                podaci = value;
            }
        }
        #endregion

        #region Metode

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
        List<Kandidat> pretraziKandidate(int minAge, int maxAge, Stranka stranka, string strucnaSprema, string pozicija, string drustvenaPriznanja, int popularnost)
        {
            List<Kandidat> kandidati = new List<Kandidat>();
            foreach (Kandidat k in KandidatiD)
                if (k.Godine <= maxAge && k.Godine >= minAge && k.Stranka == stranka
                    && k.StrucnaSprema == strucnaSprema && k.Pozicija == pozicija && k.Popularnost >= popularnost)
                    kandidati.Add(k);
            return kandidati;
        }
        #endregion
    }
}
