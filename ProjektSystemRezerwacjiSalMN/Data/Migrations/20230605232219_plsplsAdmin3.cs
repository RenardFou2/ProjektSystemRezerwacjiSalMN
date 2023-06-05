using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class plsplsAdmin3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b3ebd475-f3d2-4d21-a3de-50853787cd1f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7132909-0b6d-4a3b-9dc6-befa1aa9013e");
        }
    }
}
