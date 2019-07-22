using Microsoft.EntityFrameworkCore.Migrations;

namespace Landmark_Remark.Migrations
{
    public partial class SeedingAnotherUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "User",
               columns: new[] { "UserID", "FirstName", "LastName", "Password", "UserName" },
               values: new object[] { 9, "Brian", "Smith", "Brian", "Brian" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
              table: "User",
              keyColumn: "UserID",
              keyValue: 9);
        }
    }
}
