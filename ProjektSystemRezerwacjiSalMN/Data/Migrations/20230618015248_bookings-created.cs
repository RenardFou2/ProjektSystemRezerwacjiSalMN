using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class bookingscreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "849295c6-5a51-440b-97e9-5f8e5c5064a5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "70bd926e-d5d8-4adc-aec3-4d6ce9301817");
        }
    }
}
