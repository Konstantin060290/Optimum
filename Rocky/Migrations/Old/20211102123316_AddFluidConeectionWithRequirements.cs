using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class AddFluidConeectionWithRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FluidId",
                table: "Requirements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_FluidId",
                table: "Requirements",
                column: "FluidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requirements_Fluid_FluidId",
                table: "Requirements",
                column: "FluidId",
                principalTable: "Fluid",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requirements_Fluid_FluidId",
                table: "Requirements");

            migrationBuilder.DropIndex(
                name: "IX_Requirements_FluidId",
                table: "Requirements");

            migrationBuilder.DropColumn(
                name: "FluidId",
                table: "Requirements");
        }
    }
}
