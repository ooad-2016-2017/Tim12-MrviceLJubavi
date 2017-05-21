using Microsoft.Data.Entity.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Migrations.Builders;

namespace GlasajBA.Migration_
{
    public partial class MigracijaKandidati : Migration
    {
        public override string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Down(MigrationBuilder migrationBuilder)
        {
            throw new NotImplementedException();
        }

        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kandidati",
                columns: table => new
                {
                    Ime = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column(type: "DATE", nullable: false), //koji je format za datum?
                    LicnaKarta = table.Column(type: "TEXT", nullable: false),
                    JMBG = table.Column(type: "TEXT", nullable: false),
                    Drzava = table.Column(type: "TEXT", nullable: false),
                    Stranka = table.Column(type: "TEXT", nullable: false), //ovdje ce biti ili FK ili samo naziv stranke
                    Godine = table.Column(type: "INTEGER", nullable: true),
                    StrucnaSprema = table.Column(type: "TEXT", nullable: false),
                    Pozicija = table.Column(type: "TEXT", nullable: false),
                    DrustvenaPriznanja = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "image", nullable: true),
                    Popularnost = table.Column(type: "INTEGER", nullable: true)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JMBG", x => x.JMBG);
                    table.Unique("UN_LicnaKarta", x => x.LicnaKarta);
                });
        }
    }
}
