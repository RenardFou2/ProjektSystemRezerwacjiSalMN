using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSystemRezerwacjiSalMN.Data.Migrations
{
    public partial class RCtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Building_BuildingId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCategory_Category_CategoryId",
                table: "RoomCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCategory_Room_RoomId",
                table: "RoomCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCategory",
                table: "RoomCategory");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "RoomCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RoomCategory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Room",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCategory",
                table: "RoomCategory",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "70bd926e-d5d8-4adc-aec3-4d6ce9301817");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCategory_RoomId",
                table: "RoomCategory",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Building_BuildingId",
                table: "Room",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCategory_Category_CategoryId",
                table: "RoomCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCategory_Room_RoomId",
                table: "RoomCategory",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Building_BuildingId",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCategory_Category_CategoryId",
                table: "RoomCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomCategory_Room_RoomId",
                table: "RoomCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCategory",
                table: "RoomCategory");

            migrationBuilder.DropIndex(
                name: "IX_RoomCategory_RoomId",
                table: "RoomCategory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RoomCategory");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "RoomCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCategory",
                table: "RoomCategory",
                columns: new[] { "RoomId", "CategoryId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "12ac067b-a43a-4e78-85de-ab1a3e96d47e");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Room_RoomId",
                table: "Equipment",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Building_BuildingId",
                table: "Room",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCategory_Category_CategoryId",
                table: "RoomCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCategory_Room_RoomId",
                table: "RoomCategory",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
