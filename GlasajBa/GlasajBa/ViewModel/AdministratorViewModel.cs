using GlasajBa.Helper;
using GlasajBa.Interfaces;
using GlasajBa.Model;
using GlasajBa.View;
using GlasajBa.ViewModel.GlasajBa.ViewModel;
using System;
using System.ServiceModel;
//using System.TwitterSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Windows.Input;
using TweetSharp;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Tweetinvi;

namespace GlasajBa.ViewModel
{
    class AdministratorViewModel : ITwitter 
    {
        #region Icommande i get i set

        public ICommand DodavanjeKandidata { get; set; } //
        public ICommand IzmjenaKandidata { get; set; } //
        public ICommand BrisanjeKandidata { get; set; } //
        public ICommand Login { get; set; } //
        public ICommand PretragaKandidata { get; set; } //
        public ICommand DodavanjeNovosti { get; set; } //
        public ICommand IzmjenaNovosti { get; set; } //
        public ICommand BrisanjeNovosti { get; set; } //
        public ICommand PretragaNovosti { get; set; } //
        public ICommand Odjava { get; set; } //
        public ICommand UcitajSliku { get; set; } //
        public ICommand OtvoriPretraguK { get; set; }
        public ICommand OtvoriPretraguN { get; set; }

        #endregion

        #region atributi
        public OstaleFunkcionalnostiViewModel Parent { get; set; }
        INavigationService INS { get; set; }
        public Stranka kojaStranka { get; set; }
        public static byte[] uploadSlika = null;
        public Novost NovaNovost { get; set; }
        public Kandidat NoviKandidat { get; set; }
        public String AdminIme { get; set; }
        public string AdminSifra { get; set; }
        public GlasackiSistem Sistem { get; set; }
        public String PoljePretrageKandidata { get; set; }
        public String PoljePretrageNovosti { get; set; }
        public List<Kandidat> ListaKandidata { get; set; }
        public List<Novost> ListaNovosti { get; set; }
        public ObservableCollection<string> NaziviStranki { get; set; }
        #endregion

        public AdministratorViewModel()
        {
            this.Sistem = new GlasackiSistem();
            //this.Sistem = Parent.Sistem;

            ListaKandidata = Sistem.KandidatiD;
            ListaNovosti = Sistem.Novosti;
            NoviKandidat = new Kandidat();
            NovaNovost = new Novost();
            NoviKandidat.DatRodjenja = DateTime.Now;
            Login = new RelayCommand<object>(registrujAdmina, potvrdi);
            DodavanjeKandidata = new RelayCommand<object>(dodajKandidata, boolDodaj);
            DodavanjeNovosti = new RelayCommand<object>(dodajNovost, boolDodaj);
            BrisanjeKandidata = new RelayCommand<object>(obrisiKandidata, boolDodaj);
            BrisanjeNovosti = new RelayCommand<object>(obrisiNovost, boolDodaj);
            IzmjenaKandidata = new RelayCommand<object>(promjenaKandidata, boolDodaj);
            IzmjenaNovosti = new RelayCommand<object>(promjenaNovosti, boolDodaj);
            Odjava = new RelayCommand<object>(odjava, boolDodaj);
            PretragaNovosti = new RelayCommand<object>(nadjiNovosti, boolDodaj);
            PretragaKandidata = new RelayCommand<object>(nadjiKandidate, boolDodaj);
            UcitajSliku = new RelayCommand<object>(dodajSliku, boolDodaj);
            NaziviStranki = new ObservableCollection<string>();
            NaziviStranki.Add("OOAD");
            NaziviStranki.Add("Proba");
            /*
            for (int i=0; i<Sistem.Stranke.Count; i++)
            {
                NaziviStranki.Add(Sistem.Stranke[i].Naziv);
            }
            */
            //NoviKandidat.ErrorsChanged += Vm_ErrorsChanged;
        }

        public AdministratorViewModel(OstaleFunkcionalnostiViewModel p)
        {

            
            NovaNovost = new Novost(DateTime.Today, null, "", "");
            NoviKandidat = new Kandidat();
            //this.Sistem = new GlasackiSistem();
            Parent = p;
            this.Sistem = Parent.Sistem;
            kojaStranka = new Stranka();
            ListaKandidata = new List<Kandidat>();
            ListaNovosti = new List<Novost>();
            INS = new NavigationService();
            Login = new RelayCommand<object>(registrujAdmina, potvrdi);
            DodavanjeKandidata = new RelayCommand<object>(dodajKandidata, boolDodaj);
            DodavanjeNovosti = new RelayCommand<object>(dodajNovost, boolDodaj);
            BrisanjeKandidata = new RelayCommand<object>(obrisiKandidata, boolDodaj);
            BrisanjeNovosti = new RelayCommand<object>(obrisiNovost, boolDodaj);
            IzmjenaKandidata = new RelayCommand<object>(promjenaKandidata, boolDodaj);
            IzmjenaNovosti = new RelayCommand<object>(promjenaNovosti, boolDodaj);
            Odjava = new RelayCommand<object>(odjava, boolDodaj);
            OtvoriPretraguK = new RelayCommand<object>(pretragaK, boolDodaj);
            OtvoriPretraguN = new RelayCommand<object>(pretragaN, boolDodaj);
            PretragaNovosti = new RelayCommand<object>(nadjiNovosti, boolDodaj);
            PretragaKandidata = new RelayCommand<object>(nadjiKandidate, boolDodaj);
            UcitajSliku = new RelayCommand<object>(dodajSliku, boolDodaj);
            NoviKandidat.ErrorsChanged += Vm_ErrorsChanged;
        }

        #region metode
        public bool potvrdi(Object o)
        {
            /*
            string password = new System.Net.NetworkCredential(string.Empty, AdminSifra).Password;
            
            if (AdminIme.Equals("admin") && password.Equals("mrviceljubavi"))
            {
                return true;
            }
            var dialog = new MessageDialog("Neispravni pristupni podaci!");
            */
            
            //stalno vraca true jer passwordBox pretvara string u SecureString, metode koje sam nasla na Internetu za pretvaranje
            //su za starije verzije VS
            return true;
        }

        public void registrujAdmina(Object o)
        {
            INS.Navigate(typeof(AdminPocetna), this);
        }

        public void pretragaN(Object o)
        {
            INS.Navigate(typeof(PretragaNovosti), this);
        }

        public void pretragaK(Object o)
        {
            INS.Navigate(typeof(Pretraga), this);
        }

        public bool boolDodaj(Object o)
        {
            return true;
        }
        
        public void dodajKandidata(Object o)
        {
            uploadSlika = UserControls.ImageAndButton.uploadSlika;
            //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(jpegByteArray));
            //NoviKandidat.Slika = ;
            NoviKandidat.DrzavaBoravka = "Bosna i Hercegovina";
            //dodati kandidata
            if (NoviKandidat.Pozicija == "Opcina")
            {
                //opcina
                Sistem.KandidatiO.Add(NoviKandidat);
            }
            else if (NoviKandidat.Pozicija == "Kanton")
            {
                //kanton
                Sistem.KandidatiK.Add(NoviKandidat);
            }
            else if (NoviKandidat.Pozicija == "Entitet")
            {
                //entitet
                Sistem.KandidatiE.Add(NoviKandidat);
            }
            else if (NoviKandidat.Pozicija == "Drzava")
            {
                //drzava
                Sistem.KandidatiD.Add(NoviKandidat);
            }
            else
            {
                return;
            }

            using (var db = new KandidateDBContext())
            {
                var contact = NoviKandidat;
                db.Kandidati.Add(contact);
                db.SaveChanges();
            }

        }

        public void dodajNovost(Object o)
        {
            //dodajTweet("Proba: Twitter radi!");
            Sistem.Novosti.Add(NovaNovost);

            //potrebno dodati kod za dodavanje Novosti u bazu

            dodajTweet(NovaNovost.Naslov +": " + NovaNovost.Tekst);
        }

        public void obrisiKandidata(Object o)
        {
            Kandidat x = null;
            for (int i = 0; i < Sistem.KandidatiD.Count; i++)
            {
                if (Sistem.KandidatiD[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    x = Sistem.KandidatiD[i];
                    Sistem.KandidatiD.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiE.Count; i++)
            {
                if (Sistem.KandidatiE[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    x = Sistem.KandidatiD[i];
                    Sistem.KandidatiE.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiK.Count; i++)
            {
                if (Sistem.KandidatiK[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    x = Sistem.KandidatiD[i];
                    Sistem.KandidatiK.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiO.Count; i++)
            {
                if (Sistem.KandidatiO[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    x = Sistem.KandidatiD[i];
                    Sistem.KandidatiO.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < ListaKandidata.Count; i++)
            {
                if (ListaKandidata[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    x = Sistem.KandidatiD[i];
                    ListaKandidata.RemoveAt(i);
                    break;
                }
            }
            if (x != null)
            {
                using (var db = new KandidateDBContext())
                {
                    db.Kandidati.Remove(x);
                    db.SaveChanges();
                }
            }


        }

        public void obrisiNovost(Object o)
        {
            for (int i = 0; i < Sistem.Novosti.Count; i++)
            {
                if (Sistem.Novosti[i].Naslov == NovaNovost.Naslov)
                {
                    Sistem.Novosti.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < ListaNovosti.Count; i++)
            {
                if (ListaNovosti[i].Naslov == NovaNovost.Naslov)
                {
                    ListaNovosti.RemoveAt(i);
                    return;
                }
            }
        }

        public void promjenaKandidata(Object o)
        {
            int poz = -1;
            for (int i = 0; i < Sistem.KandidatiD.Count; i++)
            {
                if (Sistem.KandidatiD[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    Sistem.KandidatiD[i].StrucnaSprema = NoviKandidat.StrucnaSprema;
                    Sistem.KandidatiD[i].Pozicija = NoviKandidat.Pozicija;
                    Sistem.KandidatiD[i].Ime = NoviKandidat.Ime;
                    Sistem.KandidatiD[i].Prezime = NoviKandidat.Prezime;
                    Sistem.KandidatiD[i].DatRodjenja = NoviKandidat.DatRodjenja;
                    Sistem.KandidatiD[i].DrustvenaPriznanja = NoviKandidat.DrustvenaPriznanja;
                    Sistem.KandidatiD[i].DrzavaBoravka = NoviKandidat.DrzavaBoravka;
                    Sistem.KandidatiD[i].Godine = NoviKandidat.Godine;
                    Sistem.KandidatiD[i].Slika = NoviKandidat.Slika;
                    Sistem.KandidatiD[i].Stranka = NoviKandidat.Stranka;
                    //poz = i;
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiE.Count; i++)
            {
                if (Sistem.KandidatiE[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    Sistem.KandidatiE[i].StrucnaSprema = NoviKandidat.StrucnaSprema;
                    Sistem.KandidatiE[i].Pozicija = NoviKandidat.Pozicija;
                    Sistem.KandidatiE[i].Ime = NoviKandidat.Ime;
                    Sistem.KandidatiE[i].Prezime = NoviKandidat.Prezime;
                    Sistem.KandidatiE[i].DatRodjenja = NoviKandidat.DatRodjenja;
                    Sistem.KandidatiE[i].DrustvenaPriznanja = NoviKandidat.DrustvenaPriznanja;
                    Sistem.KandidatiE[i].DrzavaBoravka = NoviKandidat.DrzavaBoravka;
                    Sistem.KandidatiE[i].Godine = NoviKandidat.Godine;
                    Sistem.KandidatiE[i].Slika = NoviKandidat.Slika;
                    Sistem.KandidatiE[i].Stranka = NoviKandidat.Stranka;
                    //poz = i;
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiK.Count; i++)
            {
                if (Sistem.KandidatiK[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    Sistem.KandidatiK[i].StrucnaSprema = NoviKandidat.StrucnaSprema;
                    Sistem.KandidatiK[i].Pozicija = NoviKandidat.Pozicija;
                    Sistem.KandidatiK[i].Ime = NoviKandidat.Ime;
                    Sistem.KandidatiK[i].Prezime = NoviKandidat.Prezime;
                    Sistem.KandidatiK[i].DatRodjenja = NoviKandidat.DatRodjenja;
                    Sistem.KandidatiK[i].DrustvenaPriznanja = NoviKandidat.DrustvenaPriznanja;
                    Sistem.KandidatiK[i].DrzavaBoravka = NoviKandidat.DrzavaBoravka;
                    Sistem.KandidatiK[i].Godine = NoviKandidat.Godine;
                    Sistem.KandidatiK[i].Slika = NoviKandidat.Slika;
                    Sistem.KandidatiK[i].Stranka = NoviKandidat.Stranka;
                    //poz = i;
                    break;
                }
            }

            for (int i = 0; i < Sistem.KandidatiO.Count; i++)
            {
                if (Sistem.KandidatiO[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    Sistem.KandidatiO[i].StrucnaSprema = NoviKandidat.StrucnaSprema;
                    Sistem.KandidatiO[i].Pozicija = NoviKandidat.Pozicija;
                    Sistem.KandidatiO[i].Ime = NoviKandidat.Ime;
                    Sistem.KandidatiO[i].Prezime = NoviKandidat.Prezime;
                    Sistem.KandidatiO[i].DatRodjenja = NoviKandidat.DatRodjenja;
                    Sistem.KandidatiO[i].DrustvenaPriznanja = NoviKandidat.DrustvenaPriznanja;
                    Sistem.KandidatiO[i].DrzavaBoravka = NoviKandidat.DrzavaBoravka;
                    Sistem.KandidatiO[i].Godine = NoviKandidat.Godine;
                    Sistem.KandidatiO[i].Slika = NoviKandidat.Slika;
                    Sistem.KandidatiO[i].Stranka = NoviKandidat.Stranka;
                    //poz = i;
                    break;
                }
            }

            for (int i = 0; i < ListaKandidata.Count; i++)
            {
                if (ListaKandidata[i].JMBG1 == NoviKandidat.JMBG1)
                {
                    ListaKandidata[i].StrucnaSprema = NoviKandidat.StrucnaSprema;
                    ListaKandidata[i].Pozicija = NoviKandidat.Pozicija;
                    ListaKandidata[i].Ime = NoviKandidat.Ime;
                    ListaKandidata[i].Prezime = NoviKandidat.Prezime;
                    ListaKandidata[i].DatRodjenja = NoviKandidat.DatRodjenja;
                    ListaKandidata[i].DrustvenaPriznanja = NoviKandidat.DrustvenaPriznanja;
                    ListaKandidata[i].DrzavaBoravka = NoviKandidat.DrzavaBoravka;
                    ListaKandidata[i].Godine = NoviKandidat.Godine;
                    ListaKandidata[i].Slika = NoviKandidat.Slika;
                    ListaKandidata[i].Stranka = NoviKandidat.Stranka;
                    poz = i;
                    break;
                }
            }
            if (poz != -1) {
                using (var db = new KandidateDBContext())
                {
                    db.Update(ListaKandidata[poz]);
                    db.SaveChanges();
                }
            }
        }

        public void promjenaNovosti(Object o)
        {
            for (int i = 0; i < Sistem.Novosti.Count; i++)
            {
                if (Sistem.Novosti[i].Naslov == NovaNovost.Naslov)
                {
                    Sistem.Novosti.RemoveAt(i);
                    Sistem.Novosti.Add(NovaNovost);
                    break;
                }
            }

            for (int i = 0; i < ListaNovosti.Count; i++)
            {
                if (ListaNovosti[i].Naslov == NovaNovost.Naslov)
                {
                    ListaNovosti.RemoveAt(i);
                    ListaNovosti.Add(NovaNovost);
                    return;
                }
            }
        }

        public void odjava(Object o)
        {
            INS.Navigate(typeof(GlavnaStranica), Parent);
        }

        public void nadjiNovosti(Object o)
        {
            ListaNovosti = new List<Novost>();
            for (int i = 0; i < Sistem.Novosti.Count; i++)
            {
                if (Sistem.Novosti[i].Naslov.Contains(PoljePretrageNovosti) || Sistem.Novosti[i].Tekst.Contains(PoljePretrageNovosti))
                {
                    ListaNovosti.Add(Sistem.Novosti[i]);
                }
            }
        }

        public void nadjiKandidate(Object o)
        {
            ListaKandidata = new List<Kandidat>();

            for (int i = 0; i < Sistem.KandidatiD.Count; i++)
            {
                String temp = Sistem.KandidatiD[i].Ime = " " + Sistem.KandidatiD[i].Prezime;
                if (temp.Contains(PoljePretrageKandidata) || Sistem.KandidatiD[i].Ime.Contains(PoljePretrageKandidata) || Sistem.KandidatiD[i].Prezime.Contains(PoljePretrageKandidata))
                {
                    ListaKandidata.Add(Sistem.KandidatiD[i]);
                }
            }

            for (int i = 0; i < Sistem.KandidatiE.Count; i++)
            {
                String temp = Sistem.KandidatiE[i].Ime = " " + Sistem.KandidatiE[i].Prezime;
                if (temp.Contains(PoljePretrageKandidata) || Sistem.KandidatiE[i].Ime.Contains(PoljePretrageKandidata) || Sistem.KandidatiE[i].Prezime.Contains(PoljePretrageKandidata))
                {
                    ListaKandidata.Add(Sistem.KandidatiE[i]);
                }
            }

            for (int i = 0; i < Sistem.KandidatiK.Count; i++)
            {
                String temp = Sistem.KandidatiK[i].Ime = " " + Sistem.KandidatiK[i].Prezime;
                if (temp.Contains(PoljePretrageKandidata) || Sistem.KandidatiK[i].Ime.Contains(PoljePretrageKandidata) || Sistem.KandidatiK[i].Prezime.Contains(PoljePretrageKandidata))
                {
                    ListaKandidata.Add(Sistem.KandidatiK[i]);
                }
            }

            for (int i = 0; i < Sistem.KandidatiO.Count; i++)
            {
                String temp = Sistem.KandidatiO[i].Ime = " " + Sistem.KandidatiO[i].Prezime;
                if (temp.Contains(PoljePretrageKandidata) || Sistem.KandidatiO[i].Ime.Contains(PoljePretrageKandidata) || Sistem.KandidatiO[i].Prezime.Contains(PoljePretrageKandidata))
                {
                    ListaKandidata.Add(Sistem.KandidatiO[i]);
                }
            }


        }

        public async void dodajSliku(Object o)
        {
            //naci kod u primjerima sa c2
            FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                uploadSlika = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray();
            }

        }

        public void dodajTweet(string s)
        {
            string[] t = s.Split(':');
            if (s.Length>140)
            {
                string[] recenice = s.Split('.');
                s = "";
                string temp = s;
                for (int i=0; i<recenice.Length; i++)
                {
                    temp += recenice[i];
                    if (temp.Length>140)
                    {
                        break;
                    }
                    s = temp;
                }
            }

            if (s=="")
            {
                s = t[0];
            }

            string costumerKey = "5GpJFJaFR4kC23T6iGDcGG9Uz";
            string cosumerKeySecret = "C5AE21YQOOZwnopuylvZQAuMi0TnVTHEOnhEp0pYCwtoYeqQtR";
            string accessToken = "843137449496887297-fQFb4dCy36ZuZb3unonItmwuTEFYQd9";
            string accessTokenSecret = "aqCPTUPcE3IcMXn4kg0DXbUU66PsUixHwKeLxcoDck25a";

            Auth.SetUserCredentials(costumerKey, cosumerKeySecret, accessToken, accessTokenSecret);
            var user = User.GetAuthenticatedUser();
            var tweet = Tweet.PublishTweet(s);
        }

        #endregion

        #region dodatno
        private void Vm_ErrorsChanged(object sender, System.ComponentModel.DataErrorsChangedEventArgs e)

        {


            Erori = new ObservableCollection<string>(NoviKandidat.Errors.Errors.Values.SelectMany(x => x).ToList());

        }

        private ObservableCollection<string> erori;

        public ObservableCollection<string> Erori { get { return erori; } set { erori = value; OnNotifyPropertyChanged("Erori"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));

        }

        #endregion
    }
}
