using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAssesment.Migrations
{
    public partial class modifydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Bills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Bills",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
