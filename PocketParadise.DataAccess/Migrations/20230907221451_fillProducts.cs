using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketParadise.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fillProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
table: "Products",
columns: new[] { "Id", "Title", "Description", "Price", "Quantity", "CategoryId", "ImageUrl" },
values: new object[,]
{
            { 1, "Pikachu Cube", "Its a cute pikachu HUH", 70.00, 2, 2, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
            { 2, "Alolan Vulpix Dome", "Latest 5G smartphone with three cameras", 40.00, 3, 2, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
            { 3, "Vaporeon Mini Cube", "Ergonomic chair with lumbar support", 20.00, 1, 3, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
            { 4, "Eeveelutions Big Boy", "Noise-cancelling over-the-ear headphones", 500.00, 1, 1, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" },
            { 5, "Mitsu Charm", "Waterproof smartwatch with heart rate monitor", 15.00, 4, 4, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" }
});

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
