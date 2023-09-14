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
            // Update data
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 2, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 2, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 3, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 4, "\\images\\product\\dba6e39d-35a1-465b-9241-652be702d11a.PNG" });
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
