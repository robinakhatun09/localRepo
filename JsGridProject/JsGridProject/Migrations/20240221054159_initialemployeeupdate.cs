using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsGridProject.Migrations
{
    public partial class initialemployeeupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "EmployeeInformations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "EmployeeInformations");
        }
    }
}
