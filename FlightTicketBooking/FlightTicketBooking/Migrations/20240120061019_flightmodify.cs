using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightTicketBooking.Migrations
{
    public partial class flightmodify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PayPrice",
                table: "Payments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayPrice",
                table: "Payments");
        }
    }
}
