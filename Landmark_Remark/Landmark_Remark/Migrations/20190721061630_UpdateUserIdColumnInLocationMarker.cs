using Microsoft.EntityFrameworkCore.Migrations;

namespace Landmark_Remark.Migrations
{
    public partial class UpdateUserIdColumnInLocationMarker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "LocationMarker",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "LocationMarker",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
