using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class equipment_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomEquipment");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "dd2d3c28-ddd8-4582-a3d8-0ce952956996");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_RoomId",
                table: "Equipment",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_RoomId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Equipment");

            migrationBuilder.CreateTable(
                name: "RoomEquipment",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomEquipment", x => new { x.RoomId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_RoomEquipment_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomEquipment_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "845b501d-b8b7-4185-b3e3-3bd2a56bc95b");

            migrationBuilder.CreateIndex(
                name: "IX_RoomEquipment_EquipmentId",
                table: "RoomEquipment",
                column: "EquipmentId");
        }
    }
}
