using GlasajBA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GlasajBA.ViewModel
{
    public class GlasanjeViewModel
    {

        ICommand glasanje;
        ICommand glasanjeNaBirackomMjestu;
        bool izborniDan;
        bool lokalniIzbori;

        public void urediBazu(List<Glasac> glasaci)
        {

        }

        public void dodajTweet(Novost novost)
        {

        }

        public void napraviAnalizu()
        {

        }

        public bool IzborniDan
        {
            get
            {
                return izborniDan;
            }
            set
            {
                izborniDan = value;
            }
        }

        public GlasanjeViewModel()
        {

        }

        public ICommand Glasanje
        {
            get
            {
                return glasanje;
            }
            set
            {
                glasanje = value;
            }
        }
        public ICommand GlasanjeNaBirackomMjestu
        {
            get
            {
                return glasanjeNaBirackomMjestu;
            }
            set
            {
                glasanjeNaBirackomMjestu = value;
            }
        }
        public bool LokalniIzbori {
            get
            {
                return lokalniIzbori;
            }
            set
            {
                lokalniIzbori = value;
            }
        }

    }
}
