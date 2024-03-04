using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Album = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Price", "SongName" },
                values: new object[,]
                {
                    { 1, "Confessions", "Usher", "Hip Hop", 0.98999999999999999, "Yeah" },
                    { 2, "Tyla", "Tyla", "Rnb", 1.99, "Water" },
                    { 3, "25", "Adele", "Pop", 0.98999999999999999, "I miss you" },
                    { 4, "N/A", "Raye", "Dance", 0.98999999999999999, "Prada" },
                    { 5, "Baduizm", "Erykah Badu", "RnB", 0.98999999999999999, "On & On" },
                    { 6, "Beautiful And Brutal Yard", "JHus ft Drake", "Hip Hop", 1.99, "Who told you" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
