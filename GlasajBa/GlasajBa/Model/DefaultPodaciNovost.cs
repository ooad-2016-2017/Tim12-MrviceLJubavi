using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace GlasajBa.Model
{
    class DefaultPodaciNovost
    {
        public static void Initialize(NovostiDBContext context)
        {
            if (!(context.Novosti.Any()))
            {
                context.Novosti.AddRange(
                    new Novost()
                    {
                        Naslov = "Ovo je prva novost",
                        Tekst = "Ovo je tekst prve novosti",
                        Slike = null,
                        DatumObjave = DateTime.Today
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
