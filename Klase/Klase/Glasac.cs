using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Glasac : Osoba
    {
        bool jeLiGlasao;
        bool naBirackomMjestu;


        public Glasac(string im, string prez, DateTime datR, string LK, string maticni, string drzava, bool glasao, bool naBirackom) : base(im, prez, datR, LK, maticni, drzava)
        {
            JeLiGlasao = glasao;
            NaBirackomMjestu = naBirackom;
        }

        public Glasac(string im, string prez, DateTime datR, string LK, string maticni, string drzava) : base(im, prez, datR, LK, maticni, drzava)
        {
        }

        public bool JeLiGlasao
        {
            get
            {
                return jeLiGlasao;
            }

            set
            {
                jeLiGlasao = value;
            }
        }

        public bool NaBirackomMjestu
        {
            get
            {
                return naBirackomMjestu;
            }

            set
            {
                naBirackomMjestu = value;
            }
        }
    }
}
