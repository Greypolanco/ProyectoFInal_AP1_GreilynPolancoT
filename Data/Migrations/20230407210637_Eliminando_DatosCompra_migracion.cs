using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAP1GreilynPolancoT.Data.Migrations
{
    /// <inheritdoc />
    public partial class EliminandoDatosCompramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Compras");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Compras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Compras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
