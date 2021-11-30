using Microsoft.EntityFrameworkCore.Migrations;

namespace UnderControl.Data.Migrations
{
    public partial class _3011User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MyData",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyData_UserId",
                table: "MyData",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyData_AspNetUsers_UserId",
                table: "MyData",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyData_AspNetUsers_UserId",
                table: "MyData");

            migrationBuilder.DropIndex(
                name: "IX_MyData_UserId",
                table: "MyData");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MyData");
        }
    }
}
