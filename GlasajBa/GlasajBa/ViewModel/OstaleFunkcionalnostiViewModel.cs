using GlasajBa.Helper;
using GlasajBa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GlasajBa.ViewModel;

namespace GlasajBa.ViewModel
{
    
    class OstaleFunkcionalnostiViewModel : Baza
    {
        ICommand PronalazakBirackogMjesta { get; set; }
        ICommand PregledNovosti { get; set; }
        ICommand PretragaKandidata { get; set; }
        ICommand SistemZaSlijepeISlabovidne { get; set; }
        GlasackiSistem sistem;        

        public GlasackiSistem Sistem
        {
            get
            {
                return sistem;
            }

            set
            {
                sistem = value;
            }
        }

        Novost novost;
        Ulica ulica;
        Kandidat kandidat;

        List<Ulica> listaUlica = new List<Ulica>();
        List<Novost> listaNovosti = new List<Novost>();
        List<Kandidat> listaKandidata = new List<Kandidat>();

        List<Kandidat> listaPronadjenihKandidata = new List<Kandidat>();

        NavigationService NavigationService { get; set; }

        public Novost Novost
        {
            get
            {
                return novost;
            }

            set
            {
                novost = value;
            }
        }

        internal Ulica Ulica
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

        internal Kandidat Kandidat
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

        internal List<Ulica> ListaUlica
        {
            get
            {
                return listaUlica;
            }

            set
            {
                listaUlica = value;
            }
        }

        public List<Novost> ListaNovosti
        {
            get
            {
                return listaNovosti;
            }

            set
            {
                listaNovosti = value;
            }
        }

        internal List<Kandidat> ListaKandidata
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

        internal List<Kandidat> ListaPronadjenihKandidata
        {
            get
            {
                return listaPronadjenihKandidata;
            }

            set
            {
                listaPronadjenihKandidata = value;
            }
        }

        int godineMin, godineMax;
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

        public OstaleFunkcionalnostiViewModel()
        {

            NavigationService = new NavigationService();

            PretragaKandidata = new RelayCommand<object>(pretragaKandidata, jeLiMogucaPretraga);
            PronalazakBirackogMjesta = new RelayCommand<object>(pronadiBirackoMjesto, jeLiMogucaPretraga);
            PregledNovosti = new RelayCommand<object>(nadjiNovosti, boolDodaj);
            //SistemZaSlijepeISlabovidne = new RelayCommand<object>();
        }

        public bool jeLiMogucaPretraga(object parametar)
        {
            return true;
        }
        public void pretragaKandidata(object parametar)
        {
            foreach (Kandidat k in Sistem.KandidatiO)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) ListaPronadjenihKandidata.Add(k);
            }
            foreach (Kandidat k in Sistem.KandidatiK)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) ListaPronadjenihKandidata.Add(k);
            }
            foreach (Kandidat k in Sistem.KandidatiE)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) ListaPronadjenihKandidata.Add(k);
            }
            foreach (Kandidat k in Sistem.KandidatiD)
            {
                if (k.Godine >= GodineMin && k.Godine <= godineMax && k.Stranka == Kandidat.Stranka && k.StrucnaSprema == Kandidat.StrucnaSprema && k.Pozicija == Kandidat.Pozicija && k.DrustvenaPriznanja == Kandidat.DrustvenaPriznanja && k.Popularnost == Kandidat.Popularnost) ListaPronadjenihKandidata.Add(k);
            }
        }
        public void pronadiBirackoMjesto(object parametar)
        {
            foreach (Ulica u in Sistem.Ulice)
            {
                if (u.Naziv == ulica.Naziv) ulica.BirackoMjesto = u.BirackoMjesto;
            }

        }
        public bool boolDodaj(Object o)
        {
            return true;
        }
        public void nadjiNovosti(Object o)
        {
            ListaNovosti = new List<Novost>();
            for (int i = 0; i < Sistem.Novosti.Count; i++)
                    ListaNovosti.Add(Sistem.Novosti[i]);  
        }

        public List<T> citajIzBaze<T>()
        {
            List<T> lista = new List<T>();
            //citaj
            return lista;
        }

        public void unesiUBazu<T>(List<T> lista)
        {
            //throw new NotImplementedException();
        }

        public void urediBazu<T>(List<T> lista)
        {
            //throw new NotImplementedException();
        }
    }

}
