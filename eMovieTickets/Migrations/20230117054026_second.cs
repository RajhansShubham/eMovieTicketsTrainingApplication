using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eMovieTickets.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cinemas_CinemaId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CinemaId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_ProducerId",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "Cinema_Id",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Producer_Id",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Cinema_Id",
                table: "Movie",
                column: "Cinema_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Producer_Id",
                table: "Movie",
                column: "Producer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cinemas_Cinema_Id",
                table: "Movie",
                column: "Cinema_Id",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_Producer_Id",
                table: "Movie",
                column: "Producer_Id",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cinemas_Cinema_Id",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_Producer_Id",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_Cinema_Id",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_Producer_Id",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Cinema_Id",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Producer_Id",
                table: "Movie");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CinemaId",
                table: "Movie",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProducerId",
                table: "Movie",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cinemas_CinemaId",
                table: "Movie",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_ProducerId",
                table: "Movie",
                column: "ProducerId",
                principalTable: "Producer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
