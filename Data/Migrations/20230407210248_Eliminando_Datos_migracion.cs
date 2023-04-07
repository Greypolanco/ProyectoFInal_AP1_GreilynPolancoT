using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAP1GreilynPolancoT.Data.Migrations
{
    /// <inheritdoc />
    public partial class EliminandoDatosmigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompraDetalles_Compras_CompraId",
                table: "CompraDetalles");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "CompraDetalles");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "CompraDetalles");

            migrationBuilder.AlterColumn<int>(
                name: "CompraId",
                table: "CompraDetalles",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_CompraDetalles_Compras_CompraId",
                table: "CompraDetalles",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "CompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompraDetalles_Compras_CompraId",
                table: "CompraDetalles");

            migrationBuilder.AlterColumn<int>(
                name: "CompraId",
                table: "CompraDetalles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "CompraDetalles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "CompraDetalles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CompraDetalles_Compras_CompraId",
                table: "CompraDetalles",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "CompraId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
