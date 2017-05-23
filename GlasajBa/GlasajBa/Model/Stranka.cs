using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class Stranka
    {
        string naziv;
        string ukratko;
        public Stranka () { }
        public Stranka(string naziv, string ukratko)
        {
            this.naziv = naziv;
            this.ukratko = ukratko;
        }
        [Key]
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
