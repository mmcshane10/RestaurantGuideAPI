using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantGuide.Migrations
{
    public partial class fixDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Neighborhood",
                table: "Restaurants",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Neighborhood",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
