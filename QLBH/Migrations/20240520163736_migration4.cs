using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLBH.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Progresses",
                columns: table => new
                {
                    ProgressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgressName = table.Column<string>(type: "nchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresses", x => x.ProgressID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "Date", nullable: false),
                    OrderTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReceiveDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ReceiveTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ReceiveAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProgressID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Progresses_ProgressID",
                        column: x => x.ProgressID,
                        principalTable: "Progresses",
                        principalColumn: "ProgressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Progresses",
                columns: new[] { "ProgressID", "ProgressName" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Processing" },
                    { 3, "Shipping" },
                    { 4, "Canceled" },
                    { 5, "Instalment" },
                    { 6, "Failed" },
                    { 7, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "OrderTime", "ProgressID", "ReceiveAddress", "ReceiveDate", "ReceiveTime" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTime(2016, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 18, 30, 0), 7, "1Z Cao Thắng, P1, Q1,TPHCM", new DateTime(2016, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 30, 0, 0) },
                    { 2L, 2L, 2L, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 40, 50, 0), 7, "123N Lê Lai, P7,QPN, TPHCM", new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3L, 3L, 1L, new DateTime(2016, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 19, 12, 0), 6, "345G Lê Lợi, P4, Q1, TP Mỹ Tho, Tiền Giang", new DateTime(2016, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 9, 0, 0, 0) },
                    { 4L, 4L, 2L, new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 42, 19, 0), 1, "1B Lý Thái Tổ, P2, TPHCM", new DateTime(2017, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProgressID",
                table: "Orders",
                column: "ProgressID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Progresses");
        }
    }
}
