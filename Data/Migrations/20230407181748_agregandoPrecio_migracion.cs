using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAP1GreilynPolancoT.Data.Migrations
{
    /// <inheritdoc />
    public partial class agregandoPreciomigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "CompraDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "CompraDetalles");
        }
    }
}
