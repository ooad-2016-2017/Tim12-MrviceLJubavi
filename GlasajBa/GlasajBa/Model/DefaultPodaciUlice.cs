using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class DefaultPodaciUlice
    {

        public static void Initialize(UlicaDBContext context)
        {
            if (!(context.Ulice.Any()))
            {
                context.Ulice.AddRange(
                    new Ulica()
                    {
                        Naziv = "Maršala Tita",
                        BirackoMjesto = "BBI Centar, Trg djece Sarajeva 1"
                    }
                    );
                context.SaveChanges();
            }
        }

    }
}
