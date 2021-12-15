using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCajasRegistradoras.Data.Migrations
{
    public partial class AddPuertoToCaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Puerto",
                table: "Cajas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puerto",
                table: "Cajas");
        }
    }
}
