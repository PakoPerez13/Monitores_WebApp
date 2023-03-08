using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monitores_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class CambioListaPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_Monitores_monitoresId",
                table: "pedidos");

            migrationBuilder.DropIndex(
                name: "IX_pedidos_monitoresId",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "monitoresId",
                table: "pedidos");

            migrationBuilder.AddColumn<int>(
                name: "pedidosid",
                table: "Monitores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monitores_pedidosid",
                table: "Monitores",
                column: "pedidosid");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitores_pedidos_pedidosid",
                table: "Monitores",
                column: "pedidosid",
                principalTable: "pedidos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitores_pedidos_pedidosid",
                table: "Monitores");

            migrationBuilder.DropIndex(
                name: "IX_Monitores_pedidosid",
                table: "Monitores");

            migrationBuilder.DropColumn(
                name: "pedidosid",
                table: "Monitores");

            migrationBuilder.AddColumn<int>(
                name: "monitoresId",
                table: "pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_monitoresId",
                table: "pedidos",
                column: "monitoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_Monitores_monitoresId",
                table: "pedidos",
                column: "monitoresId",
                principalTable: "Monitores",
                principalColumn: "Id");
        }
    }
}
