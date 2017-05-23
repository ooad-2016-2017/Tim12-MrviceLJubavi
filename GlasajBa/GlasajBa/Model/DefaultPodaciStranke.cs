using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class DefaultPodaciStranke
    {
        public static void Initialize(StrankaDBContext context)
        {
            if (!(context.Stranke.Any()))
            {
                context.Stranke.AddRange(
                    new Stranka()
                    {
                        Naziv="OOAD",
                        Ukratko="Stranka za bolju ocjenu! Zalazemo se za 30b na projektu!"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
