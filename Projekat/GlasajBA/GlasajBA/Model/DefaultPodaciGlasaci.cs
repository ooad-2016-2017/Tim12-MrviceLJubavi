using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Model
{
    class DefaultPodaciGlasaci
    {
        public static void Initialize(GlasacDbContext context)
        {
            if (!context.Glasaci.Any())
            {
                context.Glasaci.AddRange(
                    new Glasac()
                    {
                        Ime = "Ehlimana",
                        Prezime = "Krupalija",
                        DatRodjenja = DateTime.Parse("30.12.1996"),
                        LicnaKarta = "nesto",
                        JMBG1 = "1234567890123",
                        DrzavaBoravka = "Bosna i Hercegovina",
                        JeLiGlasao = false,
                        NaBirackomMjestu = false,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
