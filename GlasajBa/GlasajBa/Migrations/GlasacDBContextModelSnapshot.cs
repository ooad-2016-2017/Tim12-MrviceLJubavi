using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using GlasajBa.Model;

namespace GlasajBaMigrations
{
    [ContextType(typeof(GlasacDBContext))]
    partial class GlasacDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
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
