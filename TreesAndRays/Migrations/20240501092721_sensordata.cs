using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreesAndRays.Migrations
{
    public partial class sensordata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SensorsData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TempCelsius = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TempFahrenheit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HumidityPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Moisture = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MoisturePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorsData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorsData");
        }
    }
}
