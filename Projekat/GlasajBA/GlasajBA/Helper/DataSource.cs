using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Helper
{
    class DataSource
    {
        List<string> strucneSpreme, pozicije, priznanja, popularnosti;

        public List<string> StrucneSpreme { get => strucneSpreme; set => strucneSpreme = value; }
        public List<string> Pozicije { get => pozicije; set => pozicije = value; }
        public List<string> Priznanja { get => priznanja; set => priznanja = value; }
        public List<string> Popularnosti { get => popularnosti; set => popularnosti = value; }

        public DataSource ()
        {
            strucneSpreme = new List<string>();
            pozicije = new List<string>();
            priznanja = new List<string>();
            popularnosti = new List<string>();
            strucneSpreme.Add("NSS");
            strucneSpreme.Add("SSS");
            strucneSpreme.Add("VSS");
            pozicije.Add("Predsjednik");
            pozicije.Add("Clan");
            priznanja.Add("Najbolji politicar");
            popularnosti.Add("Nepopularan");
            popularnosti.Add("Popularan");
        }
    }
}
