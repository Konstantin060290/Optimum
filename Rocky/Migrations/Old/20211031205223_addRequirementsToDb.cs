using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class addRequirementsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FluidTemperature = table.Column<decimal>(nullable: false),
                    QapacityNeed = table.Column<decimal>(nullable: false),
                    P2Need = table.Column<decimal>(nullable: false),
                    NPIPA = table.Column<decimal>(nullable: false),
                    TemperatureOfAir = table.Column<decimal>(nullable: false),
                    Placement = table.Column<string>(nullable: false),
                    SizeOfParticles = table.Column<decimal>(nullable: false),
                    PlacementExplosionCategory = table.Column<decimal>(nullable: false),
                    CustomerName = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requirements");
        }
    }
}
