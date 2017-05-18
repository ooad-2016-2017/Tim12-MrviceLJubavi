using GlasajBA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GlasajBA.ViewModel
{
    public interface Baza
    {
        List<T> citajIzBaze<T>();
        void unesiUBazu<T>(List<T> lista);
        void urediBazu<T>(List<T> lista);
    }
    public interface Analiza
    {
        string napraviAnalizu();
    }
    public interface Twitter
    {
        void dodajTweet(Novost novost);
    }
    public class GlasanjeViewModel : Baza, Analiza, Twitter
    {
        public OstaleFunkcionalnostiViewModel Parent { get; set; }
        Glasac glasac;
        Kandidat kandidat;
        Ulica ulica;
        int godineMin, godineMax;
        ICommand Glasanje { get; set; }
        ICommand PrelazakNaOpcinu { get; set; }
        ICommand PrelazakNaKanton { get; set; }
        ICommand PrelazakNaEntitet { get; set; }
        ICommand PrelazakNaDrzavu { get; set; }
        ICommand PovratakNaGlavnu { get; set; }
        ICommand PretragaKandidata { get; set; }
        ICommand PronalazakBirackogMjesta { get; set; }
        INavigationService NavigationService { get; set; }
        public Glasac Glasac { get => glasac; set => glasac = value; }
        public List<Kandidat> RezultatiPretrage { get => rezultatiPretrage; set => rezultatiPretrage = value; }
        public List<Kandidat> ListaKandidata { get => listaKandidata; set => listaKandidata = value; }
        public Kandidat Kandidat { get => kandidat; set => kandidat = value; }
        public int GodineMin { get => GodineMin1; set => GodineMin1 = value; }
        public int GodineMin1 { get => godineMin; set => godineMin = value; }
        public Ulica Ulica { get => ulica; set => ulica = value; }

        List<Kandidat> listaKandidata;
        List<Kandidat> rezultatiPretrage = new List<Kandidat>();
        public GlasanjeViewModel(OstaleFunkcionalnostiViewModel parent)
        {
            this.Parent = parent;
            ListaKandidata = Parent.Sistem.KandidatiO;
            NavigationService = new NavigationService();
            Glasanje = new RelayCommand<object>(glasanje, jeLiIzborniDan);
            PrelazakNaOpcinu = new RelayCommand<object>(prediNaOpcinu, jeLiIzborniDan);
            PrelazakNaKanton = new RelayCommand<object>(prediNaKanton, jeLiIzborniDan);
            PrelazakNaEntitet = new RelayCommand<object>(prediNaEntitet, jeLiIzborniDan);
            PrelazakNaDrzavu = new RelayCommand<object>(prediNaDrzavu, jeLiIzborniDan);
            PretragaKandidata = new RelayCommand<object>(pretragaKandidata, jeLiMogucaPretraga);
            PovratakNaGlavnu = new RelayCommand<object>(vratiSe, jeLiIzborniDan);
            PronalazakBirackogMjesta = new RelayCommand<object>(pronadiBirackoMjesto, jeLiMogucaPretraga);
        }
        public bool jeLiMogucaPretraga (object parametar)
        {
            return true;
        }
        public bool jeLiIzborniDan (object parametar)
        {
            return (DateTime.Now > Parent.Sistem.Pocetak && DateTime.Now < Parent.Sistem.Kraj);
        }
        public void glasanje (object parametar)
        {
            foreach (Glasac g in Parent.Sistem.Glasaci)
            {
                if (g.JMBG1 == glasac.JMBG1)
                {
                    g.JeLiGlasao = true;
                    break;
                }
            }
            NavigationService.Navigate(typeof(GlasajBA.View.GlavnaStranica), Parent);
        }
        public void prediNaOpcinu (object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiO;
        }
        public void prediNaKanton (object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiK;
        }
        public void prediNaEntitet (object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiE;
        }
        public void prediNaDrzavu (object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiD;
        }
        public void vratiSe (object parametar)
        {
            //Parent.NavigationService.GoBack();
            //elma treba implementirati navigationservice kao što sam i ja, tad više neće javljati error
        }
        public void pretragaKandidata (object parametar)
        {
            foreach (Kandidat k in Parent.Sistem.KandidatiO)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) RezultatiPretrage.Add(k);
            }
            foreach (Kandidat k in Parent.Sistem.KandidatiK)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) RezultatiPretrage.Add(k);
            }
            foreach (Kandidat k in Parent.Sistem.KandidatiE)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) RezultatiPretrage.Add(k);
            }
            foreach (Kandidat k in Parent.Sistem.KandidatiD)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) RezultatiPretrage.Add(k);
            }
        }
        public void pronadiBirackoMjesto (object parametar)
        {
            foreach (Ulica u in Parent.Sistem.Ulice)
            {
                if (u.Naziv == ulica.Naziv) ulica.BirackoMjesto = u.BirackoMjesto;
            }
            //ovdje će se implementirati povezivanje s mapama
        }
        public List<Glasac> citajIzBaze<Glasac> ()
        {
            return new List<Glasac>();
            //rad s bazom, ovaj return sam stavila da ne javlja error
        }
        public void unesiUBazu<Glasac> (List<Glasac> glasaci)
        {
            //rad s bazom
        }
        public void urediBazu<Glasac>(List<Glasac> glasaci)
        {
            //rad s bazom
        }

        public void dodajTweet(Novost novost)
        {
            //ovo će se naknadno implementirati
        }
        public string napraviAnalizu()
        {
            int brojGlasova = 0;
            foreach (Glasac g in Parent.Sistem.Glasaci)
            {
                if (g.JeLiGlasao) brojGlasova++;
            }
            return ("Glasalo: " + brojGlasova.ToString() + "\nNije glasalo: " + (Parent.Sistem.Glasaci.Count - brojGlasova).ToString());
        }
    }
}
