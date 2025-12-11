using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class editAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories");

            migrationBuilder.RenameTable(
                name: "ItemCategories",
                newName: "ItemVariantAttributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVariantAttributes",
                table: "ItemVariantAttributes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVariantAttributes",
                table: "ItemVariantAttributes");

            migrationBuilder.RenameTable(
                name: "ItemVariantAttributes",
                newName: "ItemCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories",
                column: "Id");
        }
    }
}
