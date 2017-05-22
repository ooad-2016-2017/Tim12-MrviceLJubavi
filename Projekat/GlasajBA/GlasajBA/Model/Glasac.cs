using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GlasajBA.Model
{
    public class Glasac : Osoba, INotifyPropertyChanged
    {
        bool jeLiGlasao;
        bool naBirackomMjestu;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public Glasac() { }

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

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
