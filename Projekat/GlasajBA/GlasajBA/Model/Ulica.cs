using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Model
{
    public class Ulica
    {
        string naziv, birackoMjesto;

        public Ulica(string naziv, string birackoMjesto)
        {
            this.naziv = naziv;
            this.birackoMjesto = birackoMjesto;
        }

        public string BirackoMjesto
        {
            get
            {
                return birackoMjesto;
            }

            set
            {
                birackoMjesto = value;
            }
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
    }
}
