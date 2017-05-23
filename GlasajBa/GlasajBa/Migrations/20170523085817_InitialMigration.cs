using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace GlasajBaMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Glasac",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", "true"),
                    DatRodjenja = table.Column(type: "TEXT", nullable: false),
                    DrzavaBoravka = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: false),
                    IsValidationEnabled = table.Column(type: "INTEGER", nullable: false),
                    JMBG1 = table.Column(type: "TEXT", nullable: false),
                    JeLiGlasao = table.Column(type: "INTEGER", nullable: false),
                    LicnaKarta = table.Column(type: "TEXT", nullable: false),
                    NaBirackomMjestu = table.Column(type: "INTEGER", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glasac", x => x.Id);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Glasac");
        }
    }
}
