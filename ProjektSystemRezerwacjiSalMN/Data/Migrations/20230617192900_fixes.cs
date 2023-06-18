using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Room",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "12ac067b-a43a-4e78-85de-ab1a3e96d47e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Room",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Room",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Room",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Room",
                type: "varchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "dd2d3c28-ddd8-4582-a3d8-0ce952956996");
        }
    }
}
