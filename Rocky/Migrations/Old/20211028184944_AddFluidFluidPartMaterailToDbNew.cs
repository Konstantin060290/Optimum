using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class AddFluidFluidPartMaterailToDbNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FluidPartMaterialId",
                table: "FluidFluidPartMaterial",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluidFluidPartMaterial_FluidPartMaterialId",
                table: "FluidFluidPartMaterial",
                column: "FluidPartMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluidFluidPartMaterial_FluidPartMaterial_FluidPartMaterialId",
                table: "FluidFluidPartMaterial",
                column: "FluidPartMaterialId",
                principalTable: "FluidPartMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluidFluidPartMaterial_FluidPartMaterial_FluidPartMaterialId",
                table: "FluidFluidPartMaterial");

            migrationBuilder.DropIndex(
                name: "IX_FluidFluidPartMaterial_FluidPartMaterialId",
                table: "FluidFluidPartMaterial");

            migrationBuilder.DropColumn(
                name: "FluidPartMaterialId",
                table: "FluidFluidPartMaterial");
        }
    }
}
