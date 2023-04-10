using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalAP1GreilynPolancoT.Data.Migrations
{
    /// <inheritdoc />
    public partial class CambiandoTipoDeDato_migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RNC",
                table: "Proveedores",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "RNC",
                table: "Proveedores",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 8);
        }
    }
}
