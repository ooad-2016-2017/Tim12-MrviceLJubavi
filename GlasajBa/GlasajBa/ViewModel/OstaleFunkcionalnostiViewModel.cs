using GlasajBa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GlasajBa.ViewModel
{
    class OstaleFunkcionalnostiViewModel
    {
        ICommand pronalazakBirackogMjesta;
        ICommand pregledNovosti;
        ICommand pretragaKandidata;
        ICommand sistemZaSlijepeISlabovidne;
        GlasackiSistem sistem;
        public ICommand SistemZaSlijepeISlabovidne
        {
            get
            {
                return sistemZaSlijepeISlabovidne;
            }

            set
            {
                sistemZaSlijepeISlabovidne = value;
            }
        }

        public ICommand PretragaKandidata
        {
            get
            {
                return pretragaKandidata;
            }

            set
            {
                pretragaKandidata = value;
            }
        }

        public ICommand PregledNovosti
        {
            get
            {
                return pregledNovosti;
            }

            set
            {
                pregledNovosti = value;
            }
        }

        public ICommand PronalazakBirackogMjesta
        {
            get
            {
                return pronalazakBirackogMjesta;
            }

            set
            {
                pronalazakBirackogMjesta = value;
            }
        }

        public GlasackiSistem Sistem
        {
            get
            {
                return sistem;
            }

            set
            {
                sistem = value;
            }
        }

        public OstaleFunkcionalnostiViewModel() { }

    }
}
