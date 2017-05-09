using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Klase
{
    public class Novost
    {
        DateTime datumObjave;
        List<Image> slike;
        string naslov, tekst;

        public Novost(DateTime datumObjave, List<Image> slike, string naslov, string tekst)
        {
            this.datumObjave = datumObjave;
            this.slike = slike;
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

        public List<Image> Slike
        {
            get
            {
                return slike;
            }

            set
            {
                slike = value;
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
    }
}
