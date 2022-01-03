using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Filmes.WebApp.Migrations
{
    public partial class ScriptAddPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Movie");
        }
    }
}
