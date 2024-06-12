using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialMachinePark.Migrations
{
    /// <inheritdoc />
    public partial class machineMigrationInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machines");
        }
    }
}
