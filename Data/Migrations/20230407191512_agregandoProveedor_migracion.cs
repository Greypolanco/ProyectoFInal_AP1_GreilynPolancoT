using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAP1GreilynPolancoT.Data.Migrations
{
    /// <inheritdoc />
    public partial class agregandoProveedormigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "CompraDetalles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "CompraDetalles");
        }
    }
}
