using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpGestionBiblio.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Livres",
                table: "Livres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprunts",
                table: "Emprunts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonnes",
                table: "Abonnes");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Livres",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Livres",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Auteur",
                table: "Livres",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Abonnes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Abonnes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livre",
                table: "Livres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprunt",
                table: "Emprunts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonne",
                table: "Abonnes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Livre",
                table: "Livres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprunt",
                table: "Emprunts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abonne",
                table: "Abonnes");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Livres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Livres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Auteur",
                table: "Livres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Abonnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Abonnes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livres",
                table: "Livres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprunts",
                table: "Emprunts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abonnes",
                table: "Abonnes",
                column: "Id");
        }
    }
}
