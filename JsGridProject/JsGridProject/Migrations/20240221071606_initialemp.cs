using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsGridProject.Migrations
{
    public partial class initialemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "EmployeeInformations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "EmployeeInformations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
