using Microsoft.EntityFrameworkCore.Migrations;

namespace BargainFetcher.Migrations
{
    public partial class updateProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebshopName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebshopName",
                table: "Products");
        }
    }
}
