using Microsoft.EntityFrameworkCore.Migrations;

namespace SetupProject.Migrations
{
    public partial class proc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgBookCost",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AvgSellingPrice",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "ProcurementOrderNumber",
                table: "ProcurementOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcurementOrderNumber",
                table: "ProcurementOrders");

            migrationBuilder.AddColumn<decimal>(
                name: "AvgBookCost",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AvgSellingPrice",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
