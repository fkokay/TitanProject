using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Titan.Data.Migrations
{
    /// <inheritdoc />
    public partial class editTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAttributeDefinitions_Items_ItemId",
                table: "ItemAttributeDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitConversions_Items_ItemId",
                table: "ItemUnitConversions");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVariantAttributes_ItemVariant_VariantId",
                table: "ItemVariantAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVariantAttributes",
                table: "ItemVariantAttributes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnitConversions",
                table: "ItemUnitConversions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemAttributeDefinitions",
                table: "ItemAttributeDefinitions");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "ItemVariantAttributes",
                newName: "ItemVariantAttribute");

            migrationBuilder.RenameTable(
                name: "ItemUnitConversions",
                newName: "ItemUnitConversion");

            migrationBuilder.RenameTable(
                name: "ItemAttributeDefinitions",
                newName: "ItemAttributeDefinition");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVariantAttributes_VariantId",
                table: "ItemVariantAttribute",
                newName: "IX_ItemVariantAttribute_VariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemUnitConversions_ItemId",
                table: "ItemUnitConversion",
                newName: "IX_ItemUnitConversion_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAttributeDefinitions_ItemId",
                table: "ItemAttributeDefinition",
                newName: "IX_ItemAttributeDefinition_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVariantAttribute",
                table: "ItemVariantAttribute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnitConversion",
                table: "ItemUnitConversion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemAttributeDefinition",
                table: "ItemAttributeDefinition",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAttributeDefinition_Items_ItemId",
                table: "ItemAttributeDefinition",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitConversion_Items_ItemId",
                table: "ItemUnitConversion",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVariantAttribute_ItemVariant_VariantId",
                table: "ItemVariantAttribute",
                column: "VariantId",
                principalTable: "ItemVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAttributeDefinition_Items_ItemId",
                table: "ItemAttributeDefinition");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitConversion_Items_ItemId",
                table: "ItemUnitConversion");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVariantAttribute_ItemVariant_VariantId",
                table: "ItemVariantAttribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVariantAttribute",
                table: "ItemVariantAttribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnitConversion",
                table: "ItemUnitConversion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemAttributeDefinition",
                table: "ItemAttributeDefinition");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "ItemVariantAttribute",
                newName: "ItemVariantAttributes");

            migrationBuilder.RenameTable(
                name: "ItemUnitConversion",
                newName: "ItemUnitConversions");

            migrationBuilder.RenameTable(
                name: "ItemAttributeDefinition",
                newName: "ItemAttributeDefinitions");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVariantAttribute_VariantId",
                table: "ItemVariantAttributes",
                newName: "IX_ItemVariantAttributes_VariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemUnitConversion_ItemId",
                table: "ItemUnitConversions",
                newName: "IX_ItemUnitConversions_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAttributeDefinition_ItemId",
                table: "ItemAttributeDefinitions",
                newName: "IX_ItemAttributeDefinitions_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVariantAttributes",
                table: "ItemVariantAttributes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnitConversions",
                table: "ItemUnitConversions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemAttributeDefinitions",
                table: "ItemAttributeDefinitions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAttributeDefinitions_Items_ItemId",
                table: "ItemAttributeDefinitions",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitConversions_Items_ItemId",
                table: "ItemUnitConversions",
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
    }
}
