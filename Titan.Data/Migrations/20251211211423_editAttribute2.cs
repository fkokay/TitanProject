using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class editAttribute2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemAttributeValues",
                table: "ItemAttributeValues");

            migrationBuilder.RenameTable(
                name: "ItemAttributeValues",
                newName: "ItemVariant");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVariant",
                table: "ItemVariant",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVariant",
                table: "ItemVariant");

            migrationBuilder.RenameTable(
                name: "ItemVariant",
                newName: "ItemAttributeValues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemAttributeValues",
                table: "ItemAttributeValues",
                column: "Id");
        }
    }
}
