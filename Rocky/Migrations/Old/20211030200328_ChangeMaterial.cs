using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class ChangeMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialOfFlowPartPump",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "FluidPartMatreialId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_FluidPartMatreialId",
                table: "Product",
                column: "FluidPartMatreialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_FluidPartMaterial_FluidPartMatreialId",
                table: "Product",
                column: "FluidPartMatreialId",
                principalTable: "FluidPartMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_FluidPartMaterial_FluidPartMatreialId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_FluidPartMatreialId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FluidPartMatreialId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "MaterialOfFlowPartPump",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
