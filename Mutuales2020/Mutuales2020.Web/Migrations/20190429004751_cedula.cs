using Microsoft.EntityFrameworkCore.Migrations;

namespace Mutuales2020.Web.Migrations
{
    public partial class cedula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "strCedulaAfi",
                table: "Affiliate",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strCedulaAfi",
                table: "Affiliate");
        }
    }
}
