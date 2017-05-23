using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using GlasajBa.Model;

namespace GlasajBaMigrations
{
    [ContextType(typeof(GlasacDBContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20170523085817_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("GlasajBa.Model.Glasac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatRodjenja");

                    b.Property<string>("DrzavaBoravka")
                        .Required();

                    b.Property<string>("Ime")
                        .Required();

                    b.Property<bool>("IsValidationEnabled");

                    b.Property<string>("JMBG1")
                        .Required();

                    b.Property<bool>("JeLiGlasao");

                    b.Property<string>("LicnaKarta")
                        .Required();

                    b.Property<bool>("NaBirackomMjestu");

                    b.Property<string>("Prezime")
                        .Required();

                    b.Key("Id");
                });
        }
    }
}
