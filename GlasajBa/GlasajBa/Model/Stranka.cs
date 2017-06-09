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
        static int idBroj=0;
        int id;
        public Stranka () { }
        public Stranka(string naziv, string ukratko)
        {
            this.naziv = naziv;
            this.ukratko = ukratko;
            idBroj++;
            id = idBroj;
        }

        [Required(ErrorMessage ="Niste unijeli naziv!")]
        public String Naziv
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

        [Required(ErrorMessage ="Niste unijeli opis!")]
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
