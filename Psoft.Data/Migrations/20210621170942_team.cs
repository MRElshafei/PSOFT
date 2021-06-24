using Microsoft.EntityFrameworkCore.Migrations;

namespace Psoft.Data.Migrations
{
    public partial class team : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<int>(
                name: "ProjectTeam",
                table: "projects",
                nullable: false,
                defaultValue: 0);

           

            
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

            migrationBuilder.DropColumn(
                name: "ProjectTeam",
                table: "projects");
        }
    }
}
