using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GlasajBa.Model
{
    class Kandidat : Osoba, INotifyPropertyChanged
    {
        Stranka stranka;
        int godine;
        string strucnaSprema, pozicija, drustvenaPriznanja;
        int popularnost;
        Image slika;
        static int idBroj = 0;
        int id;
        public Kandidat() { }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        [Required(ErrorMessage ="Morate odabrati stranku!")]
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

        [Required(ErrorMessage ="Niste unijeli sliku!")]
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

        [Required(ErrorMessage ="Niste unijeli strucnu spremu!")]
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

        [Required(ErrorMessage ="Niste odabrali poziciju!")]
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

        public static int IdBroj
        {
            get
            {
                return idBroj;
            }

            set
            {
                idBroj = value;
            }
        }
        [Key]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava, Image img) : base(im, prez, datR, LK, maticni, drzava)
        { }
        public Kandidat(string im, string prez, DateTime datR, string LK, string maticni, string drzava, Stranka stranka, int godine, string strucnaSprema, string pozicija, string drustvenaPriznanja, Image img, int popularnost = 0) : base(im, prez, datR, LK, maticni, drzava)
        {
            this.stranka = stranka;
            this.godine = godine;
            this.godine = (int)((DateTime.Today - datR).TotalDays / 365.2425);
            this.strucnaSprema = strucnaSprema;
            this.pozicija = pozicija;
            this.drustvenaPriznanja = drustvenaPriznanja;
            this.popularnost = popularnost;
            this.slika = img;
            this.id = idBroj;
            idBroj++;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
