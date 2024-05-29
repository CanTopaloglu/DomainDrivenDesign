using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DomainDrivenDesign.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Town",
                table: "Users",
                newName: "Town");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Users",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_FullAddress",
                table: "Users",
                newName: "FullAddress");

            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "Users",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Users",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullAddress",
                table: "Users",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Town",
                table: "Users",
                newName: "Address_Town");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Users",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "Users",
                newName: "Address_FullAddress");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Users",
                newName: "Address_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Users",
                newName: "Address_City");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Town",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Street",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_FullAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
