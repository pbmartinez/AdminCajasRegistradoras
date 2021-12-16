using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCajasRegistradoras.Data.Migrations
{
    public partial class AddNombreToConfiguracionEncabezado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Encabezados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Encabezados");
        }
    }
}
