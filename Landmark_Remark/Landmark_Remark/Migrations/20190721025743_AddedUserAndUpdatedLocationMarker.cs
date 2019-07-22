using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Landmark_Remark.Migrations
{
    public partial class AddedUserAndUpdatedLocationMarker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "LocationMarker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "LocationMarker",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "LocationMarker",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationMarker_User_UserID1",
                table: "LocationMarker");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_LocationMarker_UserID1",
                table: "LocationMarker");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "LocationMarker");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "LocationMarker");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "LocationMarker");
        }
    }
}
