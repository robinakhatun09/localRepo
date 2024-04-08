using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KendoDynamicGrid.Migrations
{
    public partial class modifystudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course",
                table: "Students");
        }
    }
}
