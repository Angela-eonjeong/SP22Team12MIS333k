using Microsoft.EntityFrameworkCore.Migrations;

namespace SetupProject.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardID",
                table: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "CreditCard1",
                table: "PaymentMethods",
                newName: "CardNumber");

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "CardNumber",
                table: "PaymentMethods",
                newName: "CreditCard1");

            migrationBuilder.AddColumn<int>(
                name: "CardID",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
