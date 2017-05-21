using GlasajBA.Model;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Migration_
{
    [ContextType(typeof(GlasacDBContext))]
    public partial class GlasaciDBContextModelSNapshot : ModelSnapshot
    {

        public override void BuildModel(ModelBuilder builder)
        {
            builder.Annotation("ProductVersion", "7.0.0-beta6-13815");
            builder.Entity("OOADProjekatBaza.GlasaciBaza.Models.Glasac", b =>
            {
                b.Property<string>("Ime");
                b.Property<string>("Prezime");
                b.Property<DateTime>("DatumRodjenja");
                b.Property<string>("LicnaKarta");
                b.Property<string>("JMBG");
                b.Property<string>("Drzava");
                b.Property<bool>("JeLiGlasao");
                b.Property<bool>("NaBirackomMjestu");
                b.Key("JMBG");
            });
        }

    }
}
