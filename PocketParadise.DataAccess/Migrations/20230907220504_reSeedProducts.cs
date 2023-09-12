using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PocketParadise.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class reSeedProducts : Migration
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
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG", 70.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG", 40.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG", 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG", 500.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG", 15.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 70.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 40.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 20.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 500.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "", 15.00m });
        }
    }
}
