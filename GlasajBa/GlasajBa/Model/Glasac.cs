using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Model
{
    class Glasac : Osoba, INotifyPropertyChanged
    {
        bool jeLiGlasao;
        bool naBirackomMjestu;
        static int idBroj = 0;
        int id;
        public event PropertyChangedEventHandler PropertyChanged;

        public Glasac() { }

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public Glasac(string im, string prez, DateTime datR, string LK, string maticni, string drzava, bool glasao, bool naBirackom) : base(im, prez, datR, LK, maticni, drzava)
        {
            Id = IdBroj;
            IdBroj++;
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

        public static int IdBroj
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
    }
}
