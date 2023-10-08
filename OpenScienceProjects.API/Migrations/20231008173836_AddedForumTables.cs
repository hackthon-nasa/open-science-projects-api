using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenScienceProjects.API.Migrations
{
    public partial class AddedForumTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "discussion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(250)", nullable: false),
                    project_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discussion", x => x.id);
                    table.ForeignKey(
                        name: "FK_discussion_project_project_id",
                        column: x => x.project_id,
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(250)", nullable: false),
                    discussion_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_comment_discussion_discussion_id",
                        column: x => x.discussion_id,
                        principalTable: "discussion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comment_discussion_id",
                table: "comment",
                column: "discussion_id");

            migrationBuilder.CreateIndex(
                name: "IX_discussion_project_id",
                table: "discussion",
                column: "project_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comment");

            migrationBuilder.DropTable(
                name: "discussion");
        }
    }
}
