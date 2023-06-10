﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDeskWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    width = table.Column<int>(type: "int", nullable: false),
                    depth = table.Column<int>(type: "int", nullable: false),
                    drawers = table.Column<int>(type: "int", nullable: false),
                    rush = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surface = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
