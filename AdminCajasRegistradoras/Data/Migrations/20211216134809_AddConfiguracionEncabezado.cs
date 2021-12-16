using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCajasRegistradoras.Data.Migrations
{
    public partial class AddConfiguracionEncabezado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encabezados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClearLog = table.Column<int>(type: "int", nullable: false),
                    EndFile = table.Column<int>(type: "int", nullable: false),
                    Abort = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    BaudRate = table.Column<int>(type: "int", nullable: true),
                    Puerto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encabezados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encabezados");
        }
    }
}
