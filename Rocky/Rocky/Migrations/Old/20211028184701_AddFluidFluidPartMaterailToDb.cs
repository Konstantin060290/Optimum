using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class AddFluidFluidPartMaterailToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluidFluidPartMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FluidId = table.Column<int>(nullable: false),
                    CorrVelForFluid = table.Column<decimal>(nullable: false),
                    Applicability = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluidFluidPartMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FluidFluidPartMaterial_Fluid_FluidId",
                        column: x => x.FluidId,
                        principalTable: "Fluid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluidFluidPartMaterial_FluidId",
                table: "FluidFluidPartMaterial",
                column: "FluidId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluidFluidPartMaterial");
        }
    }
}
