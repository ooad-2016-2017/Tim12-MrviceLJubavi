using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class Ulica : ValidatableBindableBase
    {
        string naziv;
        [Required(ErrorMessage = "Niste unijeli ime")]
        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                SetProperty(ref naziv, value);
            }
        }
        string birackoMjesto;

        public Ulica(string naziv, string birackoMjesto)
        {
            this.naziv = naziv;
            this.birackoMjesto = birackoMjesto;
        }

        public Ulica() { }

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
    }
}
