using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenScienceProjects.API.Migrations
{
    public partial class RemovedSkillsAndInterests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_interest");

            migrationBuilder.DropTable(
                name: "user_skill");

            migrationBuilder.DropTable(
                name: "interest");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.CreateTable(
                name: "user_tag",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    tag_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tag", x => new { x.user_id, x.tag_id });
                    table.ForeignKey(
                        name: "FK_user_tag_tag_user_id",
                        column: x => x.user_id,
                        principalTable: "tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_tag_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_tag");

            migrationBuilder.CreateTable(
                name: "interest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_interest",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    interest_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_interest", x => new { x.user_id, x.interest_id });
                    table.ForeignKey(
                        name: "FK_user_interest_interest_interest_id",
                        column: x => x.interest_id,
                        principalTable: "interest",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_interest_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_skill",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    skill_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_skill", x => new { x.user_id, x.skill_id });
                    table.ForeignKey(
                        name: "FK_user_skill_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_skill_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_interest_interest_id",
                table: "user_interest",
                column: "interest_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_skill_skill_id",
                table: "user_skill",
                column: "skill_id");
        }
    }
}
