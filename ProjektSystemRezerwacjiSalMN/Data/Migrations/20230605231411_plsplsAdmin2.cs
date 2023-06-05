using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class plsplsAdmin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "c7132909-0b6d-4a3b-9dc6-befa1aa9013e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
