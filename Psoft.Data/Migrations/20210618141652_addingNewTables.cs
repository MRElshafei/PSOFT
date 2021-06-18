using Microsoft.EntityFrameworkCore.Migrations;

namespace Psoft.Data.Migrations
{
    public partial class addingNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractorID",
                table: "projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "projects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_projects_ContractorID",
                table: "projects",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_projects_OwnerID",
                table: "projects",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Contractors_ContractorID",
                table: "projects",
                column: "ContractorID",
                principalTable: "Contractors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Owner_OwnerID",
                table: "projects",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_Contractors_ContractorID",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_Owner_OwnerID",
                table: "projects");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_projects_ContractorID",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_OwnerID",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "ContractorID",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "projects");
        }
    }
}
