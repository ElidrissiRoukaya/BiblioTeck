using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpGestionBiblio.Migrations
{
    public partial class AddUsernameAndPasswordToAbonne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Abonnes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Abonnes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Abonnes");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Abonnes");
        }
    }
}
