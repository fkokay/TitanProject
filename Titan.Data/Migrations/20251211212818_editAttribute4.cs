using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class editAttribute4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VariantId",
                table: "StockTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VariantId",
                table: "InvoiceLines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemVariantAttributes_VariantId",
                table: "ItemVariantAttributes",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVariant_ItemId",
                table: "ItemVariant",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributeDefinitions_ItemId",
                table: "ItemAttributeDefinitions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_VariantId",
                table: "InvoiceLines",
                column: "VariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceLines_ItemVariant_VariantId",
                table: "InvoiceLines",
                column: "VariantId",
                principalTable: "ItemVariant",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAttributeDefinitions_Items_ItemId",
                table: "ItemAttributeDefinitions",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVariant_Items_ItemId",
                table: "ItemVariant",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVariantAttributes_ItemVariant_VariantId",
                table: "ItemVariantAttributes",
                column: "VariantId",
                principalTable: "ItemVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceLines_ItemVariant_VariantId",
                table: "InvoiceLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAttributeDefinitions_Items_ItemId",
                table: "ItemAttributeDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVariant_Items_ItemId",
                table: "ItemVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVariantAttributes_ItemVariant_VariantId",
                table: "ItemVariantAttributes");

            migrationBuilder.DropIndex(
                name: "IX_ItemVariantAttributes_VariantId",
                table: "ItemVariantAttributes");

            migrationBuilder.DropIndex(
                name: "IX_ItemVariant_ItemId",
                table: "ItemVariant");

            migrationBuilder.DropIndex(
                name: "IX_ItemAttributeDefinitions_ItemId",
                table: "ItemAttributeDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceLines_VariantId",
                table: "InvoiceLines");

            migrationBuilder.DropColumn(
                name: "VariantId",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "VariantId",
                table: "InvoiceLines");
        }
    }
}
