using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAssesment.Migrations
{
    public partial class modifyshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Accounts",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Accounts",
                newName: "Name");
        }
    }
}
