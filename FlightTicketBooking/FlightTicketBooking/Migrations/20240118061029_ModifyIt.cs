using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightTicketBooking.Migrations
{
    public partial class ModifyIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PassengerContact",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassengerContact",
                table: "Bookings");
        }
    }
}
