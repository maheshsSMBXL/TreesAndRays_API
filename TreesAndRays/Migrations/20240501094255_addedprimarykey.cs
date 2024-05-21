using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreesAndRays.Migrations
{
    public partial class addedprimarykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SensorsData",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SensorsData");
        }
    }
}
