using GlasajBa.Helper;
using GlasajBa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace GlasajBa.ViewModel
{
    class AdministratorViewModel
    {
        /*
           sta fali:
           -punjenje comboboxa sa nazivima stranki
           -kako implementirati da se Stranka sacuva u bazu???
           -kod ucitavanja slike

       */
        ICommand dodavanjeKandidata; //
        ICommand izmjenaKandidata; //
        ICommand brisanjeKandidata; //
        ICommand login; //
        ICommand pretragaKandidata; //
        ICommand DodavanjeNovosti { get; set; } //
        ICommand IzmjenaNovosti { get; set; } //
        ICommand BrisanjeNovosti { get; set; } //
        ICommand PretragaNovosti { get; set; } //
        ICommand Odjava { get; set; } //
        ICommand UcitajSliku { get; set; }
        byte[] uploadSlika = null;

        public OstaleFunkcionalnostiViewModel Parent { get; set; }
        INavigationService INS { get; set; }

        public Novost NovaNovost { get; set; }
        public Kandidat NoviKandidat { get; set; }
        public String AdminIme { get; set; }
        public String AdminSifra { get; set; }
        public GlasackiSistem Sistem { get; set; }
        public String PoljePretrageKandidata { get; set; }
        public String PoljePretrageNovosti { get; set; }
        public List<Kandidat> ListaKandidata { get; set; }
        public List<Novost> ListaNovosti { get; set; }

        public ICommand DodavanjeKandidata
        {
            get
            {
                return dodavanjeKandidata;
            }

            set
            {
                dodavanjeKandidata = value;
            }
        }

        public ICommand IzmjenaKandidata
        {
            get
            {
                return izmjenaKandidata;
            }

            set
            {
                izmjenaKandidata = value;
            }
        }

        public ICommand BrisanjeKandidata
        {
            get
            {
                return brisanjeKandidata;
            }

            set
            {
                brisanjeKandidata = value;
            }
        }

        public ICommand Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public ICommand PretragaKandidata
        {
            get
            {
                return pretragaKandidata;
            }

            set
            {
                pretragaKandidata = value;
            }
        }

        public AdministratorViewModel()
        {

            NovaNovost = new Novost(DateTime.Today, null, "", "");
            NoviKandidat = new Kandidat();
            this.Sistem = Parent.Sistem;

            ListaKandidata = new List<Kandidat>();
            ListaNovosti = new List<Novost>();

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

        }

        public bool potvrdi(Object o)
        {
            if (AdminIme == "admin" && AdminSifra == "mrviceljubavi")
            {
                return true;
            }
            return false;
        }

        public void registrujAdmina(Object o)
        {
            INS.Navigate(typeof(GlasajBa.View.AdminPocetna), Parent);
        }

        public bool boolDodaj(Object o)
        {
            return true;
        }

        public void dodajKandidata(Object o)
        {
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
            Sistem.Novosti.Add(NovaNovost);

            //potrebno dodati kod za dodavanje Novosti

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
            //Navigate na pocetnu
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
                //uploadSlika = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray();
            }

        }
    }
}
