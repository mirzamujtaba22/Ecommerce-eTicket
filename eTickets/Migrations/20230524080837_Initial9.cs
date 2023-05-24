using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class Initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Cinemas_CinemaId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_CinemaId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Actors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_CinemaId",
                table: "Actors",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Cinemas_CinemaId",
                table: "Actors",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
