using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBa.Azure
{
    class Glasaci
    {
        public string id {get;set;}
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string LicnaKarta { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public Boolean Glasao { get; set; }
        public Boolean NaBirackom { get; set; }

    }
}
