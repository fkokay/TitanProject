using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class editItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CyphCode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupCode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name2",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name3",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name4",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ReturnVat",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SellVat",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SpeCode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpeCode2",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpeCode3",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpeCode4",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpeCode5",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Vat",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CyphCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ManufacturerCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Name2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Name3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Name4",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ReturnVat",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SellVat",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpeCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpeCode2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpeCode3",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpeCode4",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SpeCode5",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Vat",
                table: "Items");
        }
    }
}
