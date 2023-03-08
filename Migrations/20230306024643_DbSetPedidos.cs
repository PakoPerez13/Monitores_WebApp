using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monitores_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class DbSetPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Monitores_monitoresId",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "pedidos");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_monitoresId",
                table: "pedidos",
                newName: "IX_pedidos_monitoresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_Monitores_monitoresId",
                table: "pedidos",
                column: "monitoresId",
                principalTable: "Monitores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_Monitores_monitoresId",
                table: "pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos");

            migrationBuilder.RenameTable(
                name: "pedidos",
                newName: "Pedidos");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_monitoresId",
                table: "Pedidos",
                newName: "IX_Pedidos_monitoresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Monitores_monitoresId",
                table: "Pedidos",
                column: "monitoresId",
                principalTable: "Monitores",
                principalColumn: "Id");
        }
    }
}
