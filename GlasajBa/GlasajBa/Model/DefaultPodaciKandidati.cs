using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class DefaultPodaciKandidati
    {
        public static void Initialize(KandidateDBContext context)
        {
            if (!(context.Kandidati.Any()))
            {
                context.Kandidati.AddRange(
                    new Kandidat()
                    {
                        Ime = "Belma",
                        Prezime = "Muftic",
                        DatRodjenja = new DateTime(1996, 6, 8),
                        LicnaKarta = "241M95835",
                        JMBG1 = "0806996176503",
                        DrzavaBoravka = "Bosna i Hercegovina",
                        Stranka = new Stranka("OOAD", "Mrvice Ljubavi").Naziv,
                        Godine = 21,
                        StrucnaSprema = "SSS",
                        Pozicija = "Općina",
                        DrustvenaPriznanja = "",
                        Popularnost = 0,
                        Slika = null
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
