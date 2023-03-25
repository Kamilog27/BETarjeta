using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BETarjetaCredito.Migrations
{
    public partial class NumeroTarjeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MumeroTarjeta",
                table: "TarjetaCreditos",
                newName: "NumeroTarjeta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroTarjeta",
                table: "TarjetaCreditos",
                newName: "MumeroTarjeta");
        }
    }
}
