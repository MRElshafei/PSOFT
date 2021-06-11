using Microsoft.EntityFrameworkCore.Migrations;

namespace Psoft.Data.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    Consultant = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    UsersID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_projects_users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BOQS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(nullable: true),
                    unit = table.Column<string>(nullable: true),
                    unit_price = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    ProjectsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOQS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOQS_projects_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BOQS_ProjectsID",
                table: "BOQS",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_projects_UsersID",
                table: "projects",
                column: "UsersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOQS");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
