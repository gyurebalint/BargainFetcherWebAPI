using Microsoft.EntityFrameworkCore.Migrations;

namespace BargainFetcher.Migrations
{
    public partial class CategoryNameCategoryLinkAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryLink",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryLink",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Products");
        }
    }
}
