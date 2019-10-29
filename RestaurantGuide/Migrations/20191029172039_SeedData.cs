using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantGuide.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Cuisine", "Name", "Neighborhood", "Quadrant" },
                values: new object[] { 1, "123 Fake St", "Thai BBQ", "Eem", "Boise", "NE" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Cuisine", "Name", "Neighborhood", "Quadrant" },
                values: new object[] { 2, "124 Fake St.", "Pizza", "Ken's Artisan Pizza", "Kerns", "SE" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Cuisine", "Name", "Neighborhood", "Quadrant" },
                values: new object[] { 3, "125 Fake St.", "Italian", "Serratto", "Nob Hill", "NW" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);
        }
    }
}
