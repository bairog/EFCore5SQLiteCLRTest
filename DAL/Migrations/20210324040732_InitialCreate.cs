using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaneBoards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlaneType = table.Column<string>(type: "TEXT", nullable: true),
                    PlaneBoardNo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaneFlights",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FlightSmena = table.Column<short>(type: "INTEGER", nullable: false),
                    FlightNo = table.Column<int>(type: "INTEGER", nullable: false),
                    PilotName = table.Column<string>(type: "TEXT", nullable: true),
                    PlaneBoardId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneFlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaneFlights_PlaneBoards_PlaneBoardId",
                        column: x => x.PlaneBoardId,
                        principalTable: "PlaneBoards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaneBoards_PlaneType_PlaneBoardNo",
                table: "PlaneBoards",
                columns: new[] { "PlaneType", "PlaneBoardNo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaneFlights_PlaneBoardId",
                table: "PlaneFlights",
                column: "PlaneBoardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaneFlights");

            migrationBuilder.DropTable(
                name: "PlaneBoards");
        }
    }
}
