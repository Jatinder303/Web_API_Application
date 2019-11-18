using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API_Application.Migrations
{
    public partial class Update_Bike_API : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Bike");

            migrationBuilder.AddColumn<string>(
                name: "Maker",
                table: "Bike",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maker",
                table: "Bike");

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Bike",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
