using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibrary.Migrations
{
    public partial class Songs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "RunTime",
                table: "Albums");

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumID = table.Column<int>(nullable: false),
                    SongName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongID);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "AlbumID", "SongName" },
                values: new object[,]
                {
                    { 1, 1, "Like A Rolling Stone" },
                    { 27, 3, "You Go On Ahead" },
                    { 26, 3, "Paper Lace" },
                    { 25, 3, "Black Swan" },
                    { 24, 3, "Apollo And The Buffalo And Anna" },
                    { 23, 3, "Idiot Heart" },
                    { 22, 3, "Silver Moons" },
                    { 21, 2, "This Heart's On Fire" },
                    { 20, 2, "Dinner Bells" },
                    { 19, 2, "It's A Curse" },
                    { 18, 2, "I'll Believe In Anything" },
                    { 17, 2, "Dear Sons And Daughters Of Hungry Ghosts" },
                    { 16, 2, "Shine A Light" },
                    { 28, 3, "Nightengale" },
                    { 15, 2, "Same Ghost Every Night" },
                    { 13, 2, "We Built Another World" },
                    { 12, 2, "Grounds For Divorce" },
                    { 11, 2, "Modern World" },
                    { 10, 2, "You Are A Runner" },
                    { 9, 1, "Desolation Row" },
                    { 8, 1, "Just Like Tom Thumb's Blues" },
                    { 7, 1, "Highway 61 Revisited" },
                    { 6, 1, "Queen Jane Approximately" },
                    { 5, 1, "Ballad Of A Thin Man" },
                    { 4, 1, "From A Buick 6" },
                    { 3, 1, "It Takes A Lot To Laugh, It Takes A Train To Cry" },
                    { 2, 1, "Tombstone Blues" },
                    { 14, 2, "Fancy Claps" },
                    { 29, 3, "Dragon's Layor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumID",
                table: "Songs",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Albums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Albums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RunTime",
                table: "Albums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1,
                columns: new[] { "GenreID", "RunTime" },
                values: new object[] { 1, 85 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 2,
                columns: new[] { "GenreID", "RunTime" },
                values: new object[] { 1, 91 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 3,
                columns: new[] { "GenreID", "RunTime" },
                values: new object[] { 1, 89 });
        }
    }
}
