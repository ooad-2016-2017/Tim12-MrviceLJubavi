using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Stranka
    {
        string naziv;
        string ukratko;

        public Stranka(string naziv, string ukratko)
        {
            this.naziv = naziv;
            this.ukratko = ukratko;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Ukratko
        {
            get
            {
                return ukratko;
            }

            set
            {
                ukratko = value;
            }
        }
    }
}
