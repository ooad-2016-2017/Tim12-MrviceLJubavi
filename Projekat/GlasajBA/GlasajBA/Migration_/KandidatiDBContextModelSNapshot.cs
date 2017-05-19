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
    [ContextType(typeof(KandidateDBContext))]
    public partial class KandidatiDBContextModelSNapshot : ModelSnapshot
    {

        public override void BuildModel(ModelBuilder builder)
        {
            builder.Annotation("ProductVersion", "7.0.0-beta6-13815");
            builder.Entity("OOADProjekatBaza.KandidatiBaza.Models.Kandidat", b =>
            {
                b.Property<string>("Ime");
                b.Property<string>("Prezime");
                b.Property<DateTime>("DatumRodjenja");
                b.Property<string>("LicnaKarta");
                b.Property<string>("JMBG");
                b.Property<string>("Drzava");
                b.Property<Stranka>("Stranka");
                b.Property<int>("Godine");
                b.Property<string>("StrucnaSprema");
                b.Property<string>("Pozicija");
                b.Property<string>("DrustvenaPriznanja");
                b.Property<byte[]>("Slika").Annotation("Relational:ColumnType", "image");
                b.Property<int>("Popularnost");
                b.Key("JMBG");
            });
        }

    }
}
