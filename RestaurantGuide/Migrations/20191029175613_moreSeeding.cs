using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantGuide.Migrations
{
    public partial class moreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "Address",
                value: "3808 N Williams Ave st 127, Portland, OR 97227");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "Address",
                value: "304 SE 28th Ave, Portland, OR 97214");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "Address",
                value: "2112 NW Kearney St, Portland, OR 97210");

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Cuisine", "Name", "Neighborhood", "Quadrant" },
                values: new object[,]
                {
                    { 4, "609 SE Ankeny St A, Portland, OR 97214", "Japanese", "Marukin", "Buckman", "SE" },
                    { 5, "813 SW Alder St, Portland, OR 97205", "American", "Bullard", "Downtown", "SW" },
                    { 6, "200 NE 28th Ave, Portland, OR 97232", "Mexican", "Guero", "Kerns", "NE" },
                    { 7, "828 SE Ash St, Portland, OR 97214", "Breakfast", "La Luna Cafe", "Buckman", "SE" },
                    { 8, "1401 SE Morrison St Ste. 101, Portland, OR 97214", "Italian", "Nostrana", "Buckman", "SE" },
                    { 9, "210 SE Martin Luther King Jr Blvd, Portland, OR 97214", "Korean", "Revelry", "Buckman", "NW" },
                    { 10, "4090 N Williams Ave, Portland, OR 97227", "Chinese", "XLB", "Nob Hill", "NE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                column: "Address",
                value: "123 Fake St");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                column: "Address",
                value: "124 Fake St.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                column: "Address",
                value: "125 Fake St.");
        }
    }
}
