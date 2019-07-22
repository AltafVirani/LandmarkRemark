using Microsoft.EntityFrameworkCore.Migrations;

namespace Landmark_Remark.Migrations
{
    public partial class updatedLocationMarkerRemoveExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationMarker_User_UserID1",
                table: "LocationMarker");

            migrationBuilder.DropIndex(
                name: "IX_LocationMarker_UserID1",
                table: "LocationMarker");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "LocationMarker");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "LocationMarker",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationMarker_UserID1",
                table: "LocationMarker",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationMarker_User_UserID1",
                table: "LocationMarker",
                column: "UserID1",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
