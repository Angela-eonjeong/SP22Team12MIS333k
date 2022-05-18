using Microsoft.EntityFrameworkCore.Migrations;

namespace SetupProject.Migrations
{
    public partial class promochange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PromoDescription",
                table: "Promotions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromoDescription",
                table: "Promotions");
        }
    }
}
