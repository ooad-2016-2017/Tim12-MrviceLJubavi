using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GlasajBA.Model
{
    public class Novost
    {
        DateTime datumObjave;
        Image slika;
        string naslov, tekst;

        public Novost(DateTime datumObjave, Image slike, string naslov, string tekst)
        {
            this.datumObjave = datumObjave;
            this.slika = slike;
            this.naslov = naslov;
            this.tekst = tekst;
        }

        public DateTime DatumObjave
        {
            get
            {
                return datumObjave;
            }

            set
            {
                datumObjave = value;
            }
        }

        public Novost() { }

        public Image Slike
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

        public string Naslov
        {
            get
            {
                return naslov;
            }

            set
            {
                naslov = value;
            }
        }

        public string Tekst
        {
            get
            {
                return tekst;
            }

            set
            {
                tekst = value;
            }
        }

        public override string ToString()
        {
            return naslov;
        }
    }
}
