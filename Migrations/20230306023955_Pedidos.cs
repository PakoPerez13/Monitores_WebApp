using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monitores_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Pedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Monitor = table.Column<int>(type: "int", nullable: false),
                    Fecha_Pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<int>(type: "int", nullable: false),
                    monitoresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Monitores_monitoresId",
                        column: x => x.monitoresId,
                        principalTable: "Monitores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_monitoresId",
                table: "Pedidos",
                column: "monitoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
