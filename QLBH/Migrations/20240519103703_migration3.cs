using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Order", "Status" },
                values: new object[,]
                {
                    { 1L, "Laptop", 1, true },
                    { 2L, "Màn hình", 4, true },
                    { 3L, "Chuột", 2, true },
                    { 4L, "Bàn phím", 3, true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageFile", "MarketPrice", "Price", "ProductName", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "Chơi game tốt", "1.png", null, 150.50m, "Laptop ToBaShi 12N4", 0, true },
                    { 2L, 1L, "Xử lý đồ họa tốt", "2.png", null, 250.50m, "Laptop ShiBaCo N4T0", 15, true },
                    { 3L, 1L, "Chơi game tốt", "3.png", null, 180.50m, "Lapto ToBaShi 12N5", 14, true },
                    { 4L, 1L, "Xử lý đồ họa tốt", "4.png", null, 250.50m, "Laptop ShiBaCo N4T1", 13, true },
                    { 5L, 1L, "Chơi game tốt", "5.png", null, 350.50m, "Laptop ToBaShi 12N6", 20, true },
                    { 6L, 1L, "Xử lý đồ họa tốt", "6.png", null, 380.50m, "Laptop ShiBaCo N4T2", 40, true },
                    { 7L, 1L, "Chơi game tốt", "7.png", null, 280.50m, "Laptop ToBaShi 12N7", 29, true },
                    { 8L, 1L, "Xử lý đồ họa tốt", "8.png", null, 450.50m, "Laptop ShiBaCo N4T3", 30, true },
                    { 9L, 1L, "Chơi game tốt", "9.png", null, 380.50m, "Laptop ToBaShi 12N8", 15, true },
                    { 10L, 1L, "Xử lý đồ họa tốt", "10.png", null, 550.50m, "Laptop ShiBaCo N4T4", 50, true },
                    { 11L, 1L, "Chơi game tốt", "11.png", null, 450.50m, "Laptop ToBaShi 12N9", 60, true },
                    { 12L, 2L, "Chơi game tốt", "13.png", null, 50.50m, "Laptop hình ToBaShi 12N4", 4, true },
                    { 14L, 2L, "Xử lý đồ họa tốt", "14.png", null, 60.50m, "Màn hình ShiBaCo N4T0", 12, true },
                    { 15L, 2L, "Chơi game tốt", "15.png", null, 60.50m, "Màn hình ToBaShi 12N5", 15, true },
                    { 16L, 2L, "Xử lý đồ họa tốt", "16.png", null, 70.50m, "Màn hình ShiBaCo N4T1", 14, true },
                    { 17L, 2L, "Chơi game tốt", "17.png", null, 70.50m, "Màn hình ToBaShi 12N6", 26, true },
                    { 18L, 2L, "Xử lý đồ họa tốt", "18.png", null, 80.50m, "Màn hình ShiBaCo N4T2", 30, true },
                    { 19L, 2L, "Chơi game tốt", "19.png", null, 80.50m, "Màn hình ToBaShi 12N7", 12, true },
                    { 20L, 2L, "Xử lý đồ họa tốt", "20.png", null, 90.50m, "Màn hình ShiBaCo N4T3", 10, true },
                    { 21L, 2L, "Chơi game tốt", "21.png", null, 100.50m, "Màn hình ToBaShi 12N8", 12, true },
                    { 22L, 2L, "Xử lý đồ họa tốt", "22.png", null, 110.50m, "Màn hình ShiBaCo N4T4", 12, true },
                    { 23L, 2L, "Chơi game tốt", "23.png", null, 110.50m, "Màn hình ToBaShi 12N9", 11, true },
                    { 24L, 2L, "Xử lý đồ họa tốt", "24.png", null, 120.00m, "Màn hình ShiBaCo N4T5", 5, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

           
        }
    }
}
