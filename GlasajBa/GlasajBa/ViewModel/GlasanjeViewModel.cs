using GlasajBa.Helper;
using GlasajBa.Interfaces;
using GlasajBa.Model;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace GlasajBa.ViewModel
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
    class GlasanjeViewModel : Baza, Analiza, ITwitter

    {
        public OstaleFunkcionalnostiViewModel Parent { get; set; }
        Glasac glasac;
        Kandidat kandidat;
        Ulica ulica;
        GpsViewModel gps;
        int godineMin, godineMax;
        ICommand Glasanje { get; set; }
        ICommand PrelazakNaOpcinu { get; set; }
        ICommand PrelazakNaKanton { get; set; }
        ICommand PrelazakNaEntitet { get; set; }
        ICommand PrelazakNaDrzavu { get; set; }
        ICommand PovratakNaGlavnu { get; set; }
        ICommand PretragaKandidata { get; set; }
        ICommand PronalazakBirackogMjesta { get; set; }
        ICommand GlasanjeNaBirackomMjestu { get; set; }
        NavigationService NavigationService { get; set; }
        public Glasac Glasac
        {
            get
            {
                return glasac;
            }
            set
            {
                glasac = value;
            }
        }
        public List<Kandidat> RezultatiPretrage
        {
            get
            {
                return rezultatiPretrage;
            }
            set
            {
                rezultatiPretrage = value;
            }
        }
        public List<Kandidat> ListaKandidata
        {
            get
            {
                return listaKandidata;
            }
            set
            {
                listaKandidata = value;
            }
        }
        public Kandidat Kandidat
        {
            get
            {
                return kandidat;
            }
            set
            {
                kandidat = value;
            }
        }
        public int GodineMin
        {
            get
            {
                return godineMin;
            }
            set
            {
                godineMin = value;
            }
        }
        public int GodineMax
        {
            get
            {
                return godineMax;
            }
            set
            {
                godineMax = value;
            }
        }
        public Ulica Ulica
        {
            get
            {
                return ulica;
            }
            set
            {
                ulica = value;
            }
        }

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
            GlasanjeNaBirackomMjestu = new RelayCommand<object>(glasajNaBirackomMjestu, jeLiIzborniDan);

            if (GlasackiSistem.slijepi)
            {
                pustiZvuk();
            }

        }
        public bool jeLiMogucaPretraga(object parametar)
        {
            return true;
        }
        public bool jeLiIzborniDan(object parametar)
        {
            return (DateTime.Now > Parent.Sistem.Pocetak && DateTime.Now < Parent.Sistem.Kraj);
        }
        public async void glasanje(object parametar)
        {
            var dialog = new MessageDialog("Da li ste sigurni da želite glasati?");
            dialog.Title = "Upit";
            dialog.Commands.Add(new UICommand { Label = "Da", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "Ne", Id = 1 });
            var res = await dialog.ShowAsync();
            if ((int)res.Id == 0)
            {
                foreach (Glasac g in Parent.Sistem.Glasaci)
                {
                    if (g.JMBG1 == glasac.JMBG1)
                    {
                        g.JeLiGlasao = true;
                        break;
                    }
                }
                urediBazu<Glasac>(Parent.Sistem.Glasaci);
                dialog = new MessageDialog("Hvala Vam na glasanju!");
                dialog.Title = "Informacija";
                dialog.Commands.Add(new UICommand { Label = "OK", Id = 0 });
                res = await dialog.ShowAsync();
                NavigationService.Navigate(typeof(GlasajBa.View.GlavnaStranica), Parent);
            }
        }
        public async void glasajNaBirackomMjestu(object parametar)
        {
            var dialog = new MessageDialog("Da li ste sigurni da želite glasati na biračkom mjestu?");
            dialog.Title = "Upit";
            dialog.Commands.Add(new UICommand { Label = "Da", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "Ne", Id = 1 });
            var res = await dialog.ShowAsync();
            if ((int)res.Id == 0)
            {
                foreach (Glasac g in Parent.Sistem.Glasaci)
                {
                    if (g.JMBG1 == glasac.JMBG1)
                    {
                        g.JeLiGlasao = true;
                        g.NaBirackomMjestu = true;
                        break;
                    }
                }
                urediBazu<Glasac>(Parent.Sistem.Glasaci);
                dialog = new MessageDialog("Hvala Vam na glasanju!");
                dialog.Title = "Informacija";
                dialog.Commands.Add(new UICommand { Label = "OK", Id = 0 });
                res = await dialog.ShowAsync();
                NavigationService.Navigate(typeof(GlasajBa.View.GlavnaStranica), Parent);
            }
        }
        public void prediNaOpcinu(object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiO;
        }
        public void prediNaKanton(object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiK;
        }
        public void prediNaEntitet(object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiE;
        }
        public void prediNaDrzavu(object parametar)
        {
            ListaKandidata = Parent.Sistem.KandidatiD;
        }
        public void vratiSe(object parametar)
        {
            //Parent.NavigationService.GoBack();
            //elma treba implementirati navigationservice kao što sam i ja, tad više neće javljati error
        }
        public void pretragaKandidata(object parametar)
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
        public void pronadiBirackoMjesto(object parametar)
        {
            foreach (Ulica u in Parent.Sistem.Ulice)
            {
                if (u.Naziv == ulica.Naziv) ulica.BirackoMjesto = u.BirackoMjesto;
            }

        }
        public List<Glasac> citajIzBaze<Glasac>()
        {
            return new List<Glasac>();
            //rad s bazom, ovaj return sam stavila da ne javlja error
        }
        public void unesiUBazu<Glasac>(List<Glasac> glasaci)
        {
            //kod mene nema ništa novo da se unosi u bazu pa ovu metodu neću ni implementirati
        }
        public void urediBazu<Glasac>(List<Glasac> glasaci)
        {
            using (var db = new GlasacDBContext())
            {
                db.Entry(glasaci).State = EntityState.Modified;
                db.SaveChanges();
            }
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

        public void dodajTweet(string s)
        {
            s = napraviAnalizu();
            string costumerKey = "5GpJFJaFR4kC23T6iGDcGG9Uz";
            string cosumerKeySecret = "C5AE21YQOOZwnopuylvZQAuMi0TnVTHEOnhEp0pYCwtoYeqQtR";
            string accessToken = "843137449496887297-fQFb4dCy36ZuZb3unonItmwuTEFYQd9";
            string accessTokenSecret = "aqCPTUPcE3IcMXn4kg0DXbUU66PsUixHwKeLxcoDck25a";

            TwitterService service = new TwitterService(costumerKey, cosumerKeySecret, accessToken, accessTokenSecret);
            service.sendTweet(new SendTweerOptions { Status = s }, (tweet, response) =>
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var dialog = new MessageDialog("Tweet uspjesno objavljen!");
                    dialog.Title = "Twitter";
                }
                else
                {
                    var dialog = new MessageDialog("Tweet nije uspjesno objavljen!");
                    dialog.Title = "Twitter";
                }
            });
        }

        private async void pustiZvuk()
        {
            MediaElement me = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Glasanje.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            me.SetSource(stream, file.ContentType);
            me.Play();
        }
    }
}
