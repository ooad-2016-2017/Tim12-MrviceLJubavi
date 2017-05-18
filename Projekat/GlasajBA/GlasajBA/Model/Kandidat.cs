using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GlasajBA.Model
{
    public class Kandidat : Osoba, INotifyPropertyChanged
    {
        Stranka stranka;
        int godine;
        string strucnaSprema, pozicija, drustvenaPriznanja;
        int popularnost;
        Image slika;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

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
                godine = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }
            set
            {
                slika = value;
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

        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava, Image img) : base(im, prez, datR, LK, maticni, drzava)
        { }

        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava, Stranka stranka, int godine, string strucnaSprema, string pozicija, string drustvenaPriznanja, int popularnost, Image img) : base(im, prez, datR, LK, maticni, drzava)
        {
            this.stranka = stranka;
            this.godine = godine;
            this.strucnaSprema = strucnaSprema;
            this.pozicija = pozicija;
            this.drustvenaPriznanja = drustvenaPriznanja;
            this.popularnost = popularnost;
            this.slika = img;
        }

    }
}
