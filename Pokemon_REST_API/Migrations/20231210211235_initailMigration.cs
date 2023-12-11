using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokemon_REST_API.Migrations
{
    /// <inheritdoc />
    public partial class initailMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthPoint = table.Column<int>(type: "int", nullable: true),
                    Attack = table.Column<int>(type: "int", nullable: true),
                    Defance = table.Column<int>(type: "int", nullable: true),
                    SpecialAttack = table.Column<int>(type: "int", nullable: false),
                    SpecialDefance = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
