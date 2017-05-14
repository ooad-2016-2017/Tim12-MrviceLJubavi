using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GlasajBA.ViewModel
{
    public class AdministratorViewModel
    {
        ICommand dodavanjeKandidata;
        ICommand izmjenaKandidata;
        ICommand brisanjeKandidata;
        ICommand login;
        ICommand pretraga;

        public ICommand DodavanjeKandidata
        {
            get
            {
                return dodavanjeKandidata;
            }

            set
            {
                dodavanjeKandidata = value;
            }
        }

        public ICommand IzmjenaKandidata
        {
            get
            {
                return izmjenaKandidata;
            }

            set
            {
                izmjenaKandidata = value;
            }
        }

        public ICommand BrisanjeKandidata
        {
            get
            {
                return brisanjeKandidata;
            }

            set
            {
                brisanjeKandidata = value;
            }
        }

        public ICommand Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public ICommand Pretraga
        {
            get
            {
                return pretraga;
            }

            set
            {
                pretraga = value;
            }
        }

        public AdministratorViewModel() { }

        public bool potvrdi(Object o)
        {
            return true; //???
        }

        public void registrujAdmina()
        {

        }

        /*
        public ICommand Attribute
        {
            get
            {
                return 
            }
            set
            {

            }
        }
        */

    }
}
