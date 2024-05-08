using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento"}, new object[]
            { "Djavan", 1980});

            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[]
            { "Foo Fighters", 1970});

            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento", }, new object[]
            { "Pitty", 2000});

           

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musica ");
        }
    }
}
