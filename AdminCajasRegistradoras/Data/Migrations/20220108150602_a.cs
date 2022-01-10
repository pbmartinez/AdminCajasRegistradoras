using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminCajasRegistradoras.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abort",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "ClearLog",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "EndFile",
                table: "Cajas");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Cajas");

            migrationBuilder.RenameColumn(
                name: "Visible",
                table: "Cajas",
                newName: "Register");

            migrationBuilder.CreateTable(
                name: "Configuraciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuraciones");

            migrationBuilder.RenameColumn(
                name: "Register",
                table: "Cajas",
                newName: "Visible");

            migrationBuilder.AddColumn<int>(
                name: "Abort",
                table: "Cajas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClearLog",
                table: "Cajas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndFile",
                table: "Cajas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Cajas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
