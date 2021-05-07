using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaylistWeb.Migrations
{
    public partial class Ezra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_playlistsID",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "playlistsID",
                table: "Songs",
                newName: "PlaylistsID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_playlistsID",
                table: "Songs",
                newName: "IX_Songs_PlaylistsID");

            migrationBuilder.AlterColumn<int>(
                name: "PlaylistsID",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Songs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_PlaylistsID",
                table: "Songs",
                column: "PlaylistsID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_PlaylistsID",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "PlaylistsID",
                table: "Songs",
                newName: "playlistsID");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_PlaylistsID",
                table: "Songs",
                newName: "IX_Songs_playlistsID");

            migrationBuilder.AlterColumn<int>(
                name: "playlistsID",
                table: "Songs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Songs",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_playlistsID",
                table: "Songs",
                column: "playlistsID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
