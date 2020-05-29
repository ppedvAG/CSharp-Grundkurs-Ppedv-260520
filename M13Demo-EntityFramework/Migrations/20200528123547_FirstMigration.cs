using Microsoft.EntityFrameworkCore.Migrations;

namespace M13Demo_EntityFramework.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DieAkkuschrauber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Modell = table.Column<string>(nullable: false),
                    Preis = table.Column<double>(nullable: false),
                    AkkuTyp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieAkkuschrauber", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DieAkkuschrauber");
        }
    }
}
