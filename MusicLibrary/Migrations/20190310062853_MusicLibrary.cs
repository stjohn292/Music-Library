using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibrary.Migrations
{
    public partial class MusicLibrary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumName = table.Column<string>(nullable: true),
                    ArtistName = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<int>(nullable: false),
                    RunTime = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "AlbumName", "ArtistName", "GenreID", "ImgPath", "Notes", "ReleaseYear", "RunTime" },
                values: new object[] { 1, "Highway 61 Revisited", "Bob Dylan.", 1, "", null, 1965, 85 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "AlbumName", "ArtistName", "GenreID", "ImgPath", "Notes", "ReleaseYear", "RunTime" },
                values: new object[] { 2, "Apologies to the Queen Mary", "Wolf Parade", 1, "", null, 2007, 91 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "AlbumName", "ArtistName", "GenreID", "ImgPath", "Notes", "ReleaseYear", "RunTime" },
                values: new object[] { 3, "Dragonslayer", "Sunset Rubdown", 1, "", null, 2011, 89 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
