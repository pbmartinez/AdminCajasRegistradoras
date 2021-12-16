using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCajasRegistradoras.Data.Migrations
{
    public partial class AddActivaToConfiguracionEncabezado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activa",
                table: "Encabezados",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activa",
                table: "Encabezados");
        }
    }
}
