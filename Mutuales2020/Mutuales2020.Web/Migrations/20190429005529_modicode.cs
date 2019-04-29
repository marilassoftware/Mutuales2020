using Microsoft.EntityFrameworkCore.Migrations;

namespace Mutuales2020.Web.Migrations
{
    public partial class modicode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "intCodigoSoc",
                table: "Affiliate",
                newName: "intCodigoAfi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "intCodigoAfi",
                table: "Affiliate",
                newName: "intCodigoSoc");
        }
    }
}
