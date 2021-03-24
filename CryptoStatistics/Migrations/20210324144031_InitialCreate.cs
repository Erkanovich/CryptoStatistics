using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoStatistics.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GfxSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClockFrequency = table.Column<int>(type: "int", nullable: false),
                    Voltage = table.Column<int>(type: "int", nullable: false),
                    MemoryFrequency = table.Column<int>(type: "int", nullable: false),
                    Wattage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GfxSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MegaHashesPerSecond = table.Column<int>(type: "int", nullable: false),
                    NumberOfCompletions = table.Column<int>(type: "int", nullable: false),
                    NumberOfErrors = table.Column<int>(type: "int", nullable: false),
                    NumberOfStales = table.Column<int>(type: "int", nullable: false),
                    GfxSettingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_GfxSettings_GfxSettingsId",
                        column: x => x.GfxSettingsId,
                        principalTable: "GfxSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_GfxSettingsId",
                table: "Sessions",
                column: "GfxSettingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "GfxSettings");
        }
    }
}
