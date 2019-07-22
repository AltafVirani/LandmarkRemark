using Microsoft.EntityFrameworkCore.Migrations;

namespace Landmark_Remark.Migrations
{
    public partial class seedingUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 6, "Guest FName", "Guest LName", "Guest", "Guest" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 7, "Mark", "Taylor", "Mark", "Mark" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 7);
        }
    }
}
