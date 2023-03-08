﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monitores_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDisponibleMonitors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Monitores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Monitores");
        }
    }
}
