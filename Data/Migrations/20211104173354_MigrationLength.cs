using Microsoft.EntityFrameworkCore.Migrations;

namespace UnderControl.Data.Migrations
{
    public partial class MigrationLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "MyData",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "MyData");
        }
    }
}
