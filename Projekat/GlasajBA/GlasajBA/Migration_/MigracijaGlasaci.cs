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
    public partial class MigracijaGlasaci : Migration
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
                name: "Glasaci",
                columns: table => new
                {
                    Ime = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column(type: "DATE", nullable: false), //koji je format za datum?
                    LicnaKarta = table.Column(type: "TEXT", nullable: false),
                    JMBG = table.Column(type: "TEXT", nullable: false),
                    Drzava = table.Column(type: "TEXT", nullable: false),
                    JeLiGlasao = table.Column(type: "INTEGER", nullable: false), //ne znam da li postoji boolean kao tip?
                    NaBirackomMjestu = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JMBG", x => x.JMBG);
                    table.Unique("UN_LicnaKarta", x => x.LicnaKarta);
                });
        }
    }
}
