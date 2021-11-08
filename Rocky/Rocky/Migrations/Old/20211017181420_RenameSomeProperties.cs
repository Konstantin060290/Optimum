using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class RenameSomeProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExplosionProof",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MaterialOfFlowPart",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "P2",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ExplosionProofPGA",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExplosionProofPump",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialOfFlowPartPGA",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialOfFlowPartPump",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "P2PGA",
                table: "Product",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TypePGA",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePump",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExplosionProofPGA",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ExplosionProofPump",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MaterialOfFlowPartPGA",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MaterialOfFlowPartPump",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "P2PGA",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TypePGA",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TypePump",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ExplosionProof",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialOfFlowPart",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "P2",
                table: "Product",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
