using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenScienceProjects.API.Migrations
{
    public partial class AddedColumnOfficialSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "official_site",
                table: "organization",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "official_site",
                table: "organization");
        }
    }
}
