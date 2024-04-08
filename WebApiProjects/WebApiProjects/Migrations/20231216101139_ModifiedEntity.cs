using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjects.Migrations
{
    public partial class ModifiedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Mobiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Mobiles");
        }
    }
}
