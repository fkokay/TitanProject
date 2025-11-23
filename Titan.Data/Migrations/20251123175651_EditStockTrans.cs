using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditStockTrans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockBalance",
                table: "StockTransactions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "StockBalance",
                table: "StockTransactions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
