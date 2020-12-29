using Microsoft.EntityFrameworkCore.Migrations;

namespace BargainFetcher.Migrations
{
    public partial class LeafCategoryDatabaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeafCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeafCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeafCategoryLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebshopName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebshopLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeafCategories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeafCategories");
        }
    }
}
