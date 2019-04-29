using Microsoft.EntityFrameworkCore.Migrations;

namespace Mutuales2020.Web.Migrations
{
    public partial class ELIMINARcampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proceso",
                table: "Affiliate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Proceso",
                table: "Affiliate",
                nullable: true);
        }
    }
}
