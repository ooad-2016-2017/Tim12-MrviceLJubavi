using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GlasajBa.Model
{
    public class Novost
    {
        DateTime datumObjave;
        Image slika;
        string naslov, tekst;
        static int idBroj=0;
        
        int id;

        public Novost(DateTime datumObjave, Image slike, string naslov, string tekst)
        {
            this.datumObjave = datumObjave;
            this.slika = slike;
            this.naslov = naslov;
            this.tekst = tekst;
            idBroj++;
            id = idBroj;
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

        [Required(ErrorMessage ="Niste unijeli naslov!")]
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

        [Required(ErrorMessage ="Niste unijeli tekst!")]
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

        public int IdBroj
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
    }
}
