using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Windows.Validation;
using System.ComponentModel.DataAnnotations;
using GlasajBA.Helper;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlasajBA.Model
{
    public abstract class Osoba : ValidatableBindableBase
    {
        string ime;
        [Required(ErrorMessage = "Niste unijeli ime")]
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                SetProperty(ref ime, value);
            }
        }

        public Osoba() { }

        string prezime;
        [Required(ErrorMessage = "Niste unijeli prezime")]
        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                SetProperty(ref prezime, value);
            }
        }
        DateTime datRodjenja;
        [PunoljetstvoPropertyAttribute(ErrorMessage="Morate biti punoljetni")]
        public DateTime DatRodjenja
        {
            get
            {
                return datRodjenja;
            }

            set
            {
                SetProperty(ref datRodjenja, value);
            }
        }
        string licnaKarta;
        [Required(ErrorMessage = "Niste unijeli broj lične karte")]
        public string LicnaKarta
        {
            get
            {
                return licnaKarta;
            }

            set
            {
                SetProperty(ref licnaKarta, value);
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        string JMBG;
        [Required(ErrorMessage = "Niste unijeli matični broj")]
        public string JMBG1
        {
            get
            {
                return JMBG;
            }

            set
            {
                SetProperty(ref JMBG, value);
            }
        }
        string drzavaBoravka;
        [Required(ErrorMessage = "Niste unijeli državu boravka")]
        public string DrzavaBoravka
        {
            get
            {
                return drzavaBoravka;
            }

            set
            {
                SetProperty(ref drzavaBoravka, value);
            }
        }
        public Osoba(string im, string prez, DateTime datR, string LK, string maticni, string drzava)
        {
            Ime = im;
            Prezime = prez;
            DatRodjenja = datR;
            LicnaKarta = LK;
            JMBG1 = maticni;
            DrzavaBoravka = drzava;
        }
    }
}
