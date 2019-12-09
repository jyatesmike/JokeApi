using Microsoft.EntityFrameworkCore.Migrations;

namespace JokeApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jokes",
                columns: table => new
                {
                    JokeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JokeType = table.Column<string>(nullable: true),
                    JokeText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jokes", x => x.JokeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jokes");
        }
    }
}
